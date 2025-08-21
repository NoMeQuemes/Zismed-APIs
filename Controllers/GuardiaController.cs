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

        public GuardiaController(ILogger<GuardiaController> logger, ApplicationDbContext Db)
        {
            _logger = logger;
            _Db = Db;
            _response = new();
        }

        // GET /guardia/sector/{id}/pacientes
        [HttpGet("sector/{id}/pacientes")]
        [ProducesResponseType(typeof(IEnumerable<PacienteGuardiaDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> ObtenerPacientesDelSector(int id, CancellationToken ct)
        {
            try
            {
                // Simulación de obtener el ID de institución desde el contexto del usuario (JWT o Claims)
                var nombreUsuario = User.Identity?.Name;
                var idInstitucion = 3; // reemplazar con tu lógica real

                var lista = await _Db.PacientesGuardia
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

        [HttpGet("api/guardia/modal-hc")]
        public async Task<IActionResult> GetModalHC(int id, bool esGuardia)
        {
            string usuario = User.Identity?.Name ?? "";
            var institucionClaim = adminController.GetClaimUser("IdInstitucion", usuario);
            int IdInstUser = Convert.ToInt32(institucionClaim ?? "0");

            var objGuardiaRegBD = await _Db.GuardiaRegistro
                .FirstOrDefaultAsync(t => t.GuardiaRegistroID == id);

            if (objGuardiaRegBD == null)
                return NotFound("GuardiaRegistro no encontrado.");

            var objSector = await _Db.GuardiaSector
                .Where(a => a.GuardiaSectorID == objGuardiaRegBD.GuardiaSectorID && !a.Anulado)
                .FirstOrDefaultAsync();

            var afiliado = await _Db.Pacientes
                .FirstOrDefaultAsync(p => p.PacienteID == objGuardiaRegBD.PacienteID);

            // Historia clínica
            var num = await _Db.Numerador_HC
                .FirstOrDefaultAsync(n => n.PacienteID == objGuardiaRegBD.PacienteID);

            string numeroHC;
            if (num == null)
            {
                var aux = await _Db.Numerador_HC
                    .OrderByDescending(p => p.Numero)
                    .FirstOrDefaultAsync();

                int incrementado = Convert.ToInt32(aux?.Numero ?? "0") + 1;
                var num_incr = new Numerador_HC
                {
                    PacienteID = objGuardiaRegBD.PacienteID,
                    Numero = incrementado.ToString().PadLeft(8, '0'),
                    Anulado = false
                };

                _Db.Numerador_HC.Add(num_incr);
                await _Db.SaveChangesAsync();

                numeroHC = num_incr.Numero;
            }
            else
            {
                numeroHC = num.Numero;
            }

            // Tipos de anamnesis
            var TiposAnamnesisRaw = await _Db.GuardiaTipoCuestionarioXSector
                .Where(a => a.GuardiaSectorID == objSector.GuardiaSectorID &&
                            !a.Anulado &&
                            !a.GuardiaSector.Anulado)
                .OrderBy(a => a.GuardiaTipoCuestionarioXSectorID)
                .Select(a => new GuardiaTipoAnamnesisView
                {
                    TipoID = a.GuardiaTipoCuestionarioID,
                    AnamnesisNombre = a.GuardiaTipoCuestionario.Nombre
                })
                .ToListAsync();

            bool mostrarContenido = objSector.ConsultaMedica || objSector.SignosVitales
                || objSector.MedicacionContinua || objSector.MedicacionDiscreta
                || objSector.ProcedimientoCuraciones || TiposAnamnesisRaw.Count > 0;

            // Obtener claims
            var userDb = await _Db.AspNetUsers.FirstOrDefaultAsync(u => u.UserName == usuario);
            var claimEnf = await _Db.AspNetUserClaims.FirstOrDefaultAsync(c =>
                c.UserId == userDb.Id && c.ClaimType == "EnfermeroID");

            var claimPres = await _Db.AspNetUserClaims.FirstOrDefaultAsync(c =>
                c.UserId == userDb.Id && c.ClaimType == "PrestadorID");

            var response = new
            {
                InstitucionID = IdInstUser,
                Guardia = esGuardia,
                Titulo = objSector?.Nombre.Trim() ?? "ERROR",
                AfiliadosInfo = afiliado,
                GuardiaRegistroID = id,
                PacienteID = objGuardiaRegBD.PacienteID,
                GuardiaSectorID = objGuardiaRegBD.GuardiaSectorID,
                Numero_HC = numeroHC,
                ConfigSector = new
                {
                    objSector.Codigo,
                    objSector.GuardiaSectorID,
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
                    objSector.InformeCCI
                },
                NoMostrarNada = !mostrarContenido,
                TiposAnamnesis = TiposAnamnesisRaw,
                Enfermero = claimEnf?.ClaimValue == "0" || claimEnf == null,
                EnfermeroID = claimEnf?.ClaimValue,
                Prestador = claimPres?.ClaimValue == "0" || claimPres == null,
                PrestadorID = claimPres?.ClaimValue
            };

            return Ok(response);
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
