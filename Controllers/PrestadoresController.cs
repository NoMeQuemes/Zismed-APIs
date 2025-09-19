using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zismed_Apis.Data;
using Zismed_Apis.Models;

namespace Zismed_Apis.Controllers
{
    public class PrestadoresController : Controller
    {

        private readonly ILogger<PrestadoresController> _logger;
        private readonly ApplicationDbContext _Db;
        protected ApiResponse _response;
        private readonly InstitucionesService _institucionesService;

        public PrestadoresController(ILogger<PrestadoresController> logger, ApplicationDbContext Db, InstitucionesService institucionesService)
        {
            _logger = logger;
            _Db = Db;
            _response = new();
            _institucionesService = institucionesService;
        }

        [HttpGet("lista-prestadores")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListaPrestadores(
            [FromQuery] int? institucionId,
            [FromQuery] int? prestadorId,
            [FromQuery] bool? guardia,
            [FromQuery] bool? internacion,
            [FromQuery] bool iosep = false)
        {
            try
            {
                IQueryable<Prestadores> listaPres;

                if (iosep)
                {
                    listaPres = _Db.Prestadores
                        .Where(b => !b.Anulado && b.Iosepddjj == true)
                        .OrderBy(b => b.Nombre);
                }
                else
                {
                    listaPres = _Db.Prestadores
                        .Where(b => !b.Anulado)
                        .OrderBy(b => b.Nombre);
                }

                if (institucionId.HasValue)
                {
                    listaPres = listaPres
                        .Join(_Db.PrestadoresInstituciones,
                            b => b.PrestadorId,
                            i => i.PrestadorId,
                            (b, i) => new { Prestador = b, Institucion = i })
                        .Where(joined => !joined.Institucion.Anulado &&
                                         joined.Institucion.InstitucionId == institucionId &&
                                         !joined.Prestador.Anulado)
                        .Select(joined => joined.Prestador)
                        .Distinct()
                        .OrderBy(b => b.Nombre);
                }

                if (guardia.HasValue && guardia.Value && internacion.HasValue && internacion.Value)
                {
                    listaPres = listaPres
                        .Where(b => b.Guardia == true || b.Internacion == true)
                        .OrderBy(b => b.Nombre);
                }
                else if (guardia.HasValue && guardia.Value)
                {
                    listaPres = listaPres
                        .Where(b => b.Guardia == true)
                        .OrderBy(b => b.Nombre);
                }
                else if (internacion.HasValue && internacion.Value)
                {
                    listaPres = listaPres
                        .Where(b => b.Internacion == true)
                        .OrderBy(b => b.Nombre);
                }

                var resultadoTipos = await listaPres
                    .Select(item => new
                    {
                        Value = item.PrestadorId.ToString(),
                        Text = $"{item.Matricula.Trim()} - {item.Nombre.TrimEnd()}",
                        Selected = prestadorId.HasValue && item.PrestadorId == prestadorId.Value
                    })
                    .ToListAsync();

                return Ok(resultadoTipos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la lista de prestadores.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Error interno del servidor." });
            }
        }
    }
}
