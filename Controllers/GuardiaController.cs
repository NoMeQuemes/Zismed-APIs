using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Zismed_Apis.Data;
using Zismed_Apis.Models;
using Zismed_Apis.Models.Dto;

namespace Zismed_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardiaController : ControllerBase
    {
        private readonly ILogger<GuardiaController> _logger;
        private readonly ApplicationDbContext _Db;
        protected ApiResponse _response;
        private readonly InstitucionesService _institucionesService;

        public GuardiaController(ILogger<GuardiaController> logger, ApplicationDbContext Db, InstitucionesService institucionesService)
        {
            _logger = logger;
            _Db = Db;
            _response = new();
            _institucionesService = institucionesService;
        }

        //Trae todos los pacientes anotados en un sector específico de la guardia
        [HttpGet("pacientePorSector/{id}/")]
        [ProducesResponseType(typeof(IEnumerable<PacienteGuardiaDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> ObtenerPacientesDelSector(int id, CancellationToken ct)
        {
            try
            {
                // Simulación de obtener el ID de institución desde el contexto del usuario (JWT o Claims)
                var nombreUsuario = User.Identity?.Name;
                var idInstitucion = 3; // reemplazar con tu lógica real

                var lista = await _Db.PacienteGuardiaDtos
                    .FromSqlRaw("EXEC sp_PacientesGuardia {0}, {1}, {2}", id, 1, idInstitucion)
                    .ToListAsync(ct);

                _response.Result = lista;
                _response.statusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error al obtener pacientes del sector {SectorId}", id);
                _response.IsExitoso = false;
                _response.statusCode = HttpStatusCode.InternalServerError;
                _response.ErrorMessages = new List<string>() { "Error al obtener los pacientes del sector.", ex.ToString() };
                return StatusCode((int)_response.statusCode, _response);
            }
        }

        //Muestra los "sectores" que tiene ese sector de guardia
        [HttpGet("modalHc")]
        public async Task<IActionResult> GetModalHC([FromQuery] int id, [FromQuery] bool esGuardia, [FromQuery] int institucionId, [FromQuery] string usuarioNombre)
        {
            var objGuardiaRegBD = await _Db.GuardiaRegistro
                .FirstOrDefaultAsync(t => t.GuardiaRegistroId == id);

            if (objGuardiaRegBD == null)
                return NotFound("GuardiaRegistro no encontrado.");

            var objSector = await _Db.GuardiaSector
                .Where(a => a.GuardiaSectorId == objGuardiaRegBD.GuardiaSectorId && !a.Anulado)
                .FirstOrDefaultAsync();

            var paciente = await _Db.Pacientes
                .FirstOrDefaultAsync(p => p.PacienteId == objGuardiaRegBD.PacienteId);

            // Verifica si ya existe numerador HC
            var num = await _Db.NumeradorHc
                .FirstOrDefaultAsync(p => p.PacienteId == objGuardiaRegBD.PacienteId);

            string numeroHC;
            if (num == null)
            {
                var aux = await _Db.NumeradorHc
                    .OrderByDescending(p => p.Numero)
                    .FirstOrDefaultAsync();

                int incrementado = Convert.ToInt32(aux?.Numero ?? "0") + 1;
                string sIncrementado = incrementado.ToString().PadLeft(8, '0');

                var nuevoNumerador = new NumeradorHc
                {
                    PacienteId = objGuardiaRegBD.PacienteId,
                    Numero = sIncrementado,
                    Anulado = false
                };

                _Db.NumeradorHc.Add(nuevoNumerador);
                await _Db.SaveChangesAsync();

                numeroHC = nuevoNumerador.Numero;
            }
            else
            {
                numeroHC = num.Numero;
            }

            // Datos del sector
            var tiposAnamnesis = await _Db.GuardiaTipoCuestionarioXsector
                .Where(a => a.GuardiaSectorId == objSector.GuardiaSectorId && !a.Anulado)
                .Select(a => new GuardiaTipoAnamnesisView
                {
                    TipoID = a.GuardiaTipoCuestionarioId,
                    AnamnesisNombre = a.GuardiaTipoCuestionario.Nombre
                })
                .OrderBy(a => a.TipoID)
                .ToListAsync();

            bool noMostrarNada = !objSector.ConsultaMedica && !objSector.SignosVitales &&
                                 !objSector.MedicacionContinua && !objSector.MedicacionDiscreta &&
                                 !objSector.ProcedimientoCuraciones && tiposAnamnesis.Count == 0;

            // Claims del usuario
            var user = await _Db.AspNetUsers.FirstOrDefaultAsync(u => u.UserName == usuarioNombre);
            string userId = user?.Id;

            var enfermeroClaim = await _Db.AspNetUserClaims.FirstOrDefaultAsync(c => c.UserId == userId && c.ClaimType == "EnfermeroID");
            var prestadorClaim = await _Db.AspNetUserClaims.FirstOrDefaultAsync(c => c.UserId == userId && c.ClaimType == "PrestadorID");

            var dto = new
            {
                InstitucionID = institucionId,
                Guardia = esGuardia,
                Titulo = objSector?.Nombre.Trim() ?? "ERROR",
                AfiliadosInfo = paciente,
                GuardiaRegistroID = objGuardiaRegBD.GuardiaRegistroId,
                PacienteID = objGuardiaRegBD.PacienteId,
                GuardiaSectorID = objGuardiaRegBD.GuardiaSectorId,
                NumeroHC = numeroHC,
                NoMostrarNada = noMostrarNada,
                TiposAnamnesis = tiposAnamnesis,
                ConfigSector = objSector == null ? null : new
                {
                    objSector.Codigo,
                    objSector.GuardiaSectorId,
                    objSector.ConsultaMedica,
                    objSector.SignosVitales,
                    objSector.MedicacionDiscreta,
                    objSector.MedicacionContinua,
                    objSector.RegistraIngreso,
                    objSector.VeGrillaAtencion,
                    objSector.ProcedimientoCuraciones,
                    objSector.Interconsulta,
                    objSector.Laboratorio,
                    objSector.Observaciones,
                    objSector.SalidaDirecta,
                    objSector.Balance,
                    objSector.Imagenes,
                    objSector.Anamnesis,
                    objSector.Consentimientos,
                    objSector.NotificacionesCovid,
                    NotificacionDengues = objSector.NotificacionDengues ?? false,
                    objSector.InformeCci
                },
                Enfermero = enfermeroClaim == null || enfermeroClaim.ClaimValue == "0" ? null : enfermeroClaim.ClaimValue,
                Prestador = prestadorClaim == null || prestadorClaim.ClaimValue == "0" ? null : prestadorClaim.ClaimValue
            };

            return Ok(dto);
        }


        [HttpGet("consultasPorPaciente")]
        public async Task<IActionResult> GetConsultasGuardia(int? registroId, int? institucionId)
        {
            // Validación de entrada
            if (!registroId.HasValue)
            {
                return BadRequest("registroId es requerido.");
            }

            // Obtener el PacienteID sin datos de usuario
            var guardia = await _Db.GuardiaRegistro
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.GuardiaRegistroId == registroId);

            if (guardia == null)
            {
                return NotFound("GuardiaRegistro no encontrado.");
            }

            var pacienteId = guardia.PacienteId;

            // Obtener el nombre del paciente
            var paciente = await _Db.Pacientes
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PacienteId == pacienteId);

            if (paciente == null)
            {
                return NotFound("Paciente no encontrado.");
            }

            var pacienteNombre = paciente.Nombre?.Trim();
            var pacienteDocumento = paciente.Documento?.Trim();

            // Optimización de consultas
            var consultas = await _Db.ConsultasAmbulatorias
                .Include(c => c.Pacientes)
                .Include(c => c.ObraSocial)
                .Where(c => !c.Anulado && c.PacienteId == pacienteId)
                .ToListAsync();

            // Recopila y mapea todos los diagnósticos en una sola pasada
            var todosLosDiagnosticosIds = new HashSet<int>();
            foreach (var consulta in consultas)
            {
                if (consulta.DiagnosticoPrincipalId != 0)
                {
                    todosLosDiagnosticosIds.Add(consulta.DiagnosticoPrincipalId);
                }

                if (!string.IsNullOrWhiteSpace(consulta.DiagnosticoPrincipalVar))
                {
                    var idsFromVar = consulta.DiagnosticoPrincipalVar
                        .Trim().Trim('|')
                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                        .Select(id => int.Parse(id.Trim()));

                    foreach (var id in idsFromVar)
                    {
                        todosLosDiagnosticosIds.Add(id);
                    }
                }
            }

            var diagnosticos = await _Db.DiagnosticosConsultas
                .Where(d => todosLosDiagnosticosIds.Contains(d.DiagnosticosConsultasId))
                .ToDictionaryAsync(d => d.DiagnosticosConsultasId);

            foreach (var consulta in consultas)
            {
                var diagnosticosDeConsulta = new List<DiagnosticosConsultas>();
                if (diagnosticos.TryGetValue(consulta.DiagnosticoPrincipalId, out var principal))
                {
                    diagnosticosDeConsulta.Add(principal);
                }
                if (!string.IsNullOrWhiteSpace(consulta.DiagnosticoPrincipalVar))
                {
                    var idsFromVar = consulta.DiagnosticoPrincipalVar
                        .Trim().Trim('|')
                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                        .Select(id => int.Parse(id.Trim()));

                    foreach (var id in idsFromVar)
                    {
                        if (diagnosticos.TryGetValue(id, out var diagnostico))
                        {
                            diagnosticosDeConsulta.Add(diagnostico);
                        }
                    }
                }
                consulta.DiagnosticosList = diagnosticosDeConsulta;
            }

            // Filtra por institución si se proporciona el ID
            var result = consultas
                .Where(c => !institucionId.HasValue || c.InstitucionId == institucionId.Value)
                .OrderByDescending(c => c.ConsultaId)
                .ToList();

            // Mapea a DTO  
            var resultDto = result.Select(c => new ConsultaAmbulatoriaDto
            {
                ConsultaId = c.ConsultaId,
                Fecha = c.Fecha,
                Evolucion = c.Evolucion,
                PacienteId = c.PacienteId,
                ObraSocialId = c.ObraSocialId,
                NombreObraSocial = c.ObraSocial?.Nombre,
                Diagnosticos = c.DiagnosticosList?.Select(d => new DiagnosticosConsultasDto
                {
                    DiagnosticosConsultasId = d.DiagnosticosConsultasId,
                    Nombre = d.Nombre
                }).ToList()
            }).ToList();

            // Respuesta en formato JSON
            return Ok(new
            {
                PacienteID = pacienteId,
                pacienteNombre = pacienteNombre,
                pacienteDocumento = pacienteDocumento,
                RegistroID = registroId,
                InstitucionID = institucionId,
                Result = resultDto
            });
        }


        public class ListadoGuardia
        {
            public int GuardiaRegistroID { get; set; }
            public string PacienteNombre { get; set; }
            public string FechaIngreso { get; set; }
            public string PrestadorRecibe { get; set; }
            public string Lugar { get; set; }
            public int? TipoCuracionID { get; set; }
            public bool Atendido { get; set; }
            public int PacienteID { get; set; }
            public int GuardiaSectorID { get; set; }
            public string SectorNombre { get; set; }
            public string SectorAnterior { get; set; }

        }

        public class GuardiaTipoAnamnesisView
        {
            public int TipoID { get; set; }

            public string AnamnesisNombre { get; set; }
        }

    }
}
