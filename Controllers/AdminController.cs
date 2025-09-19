using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zismed_Apis.Data; // Asegúrate de que este espacio de nombres sea correcto
using System.Linq;
using Zismed_Apis.Models;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Zismed_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        protected ApiResponse _ApiResponse;

        // Constructor con inyección de dependencias
        public AdminController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _ApiResponse = new();
        }

        [HttpGet("GetClaimUser")]
        public string GetClaimUser(string claimName, string userName)
        {
            var aspnetuser = _dbContext.AspNetUsers
                .FirstOrDefault(b => b.UserName == userName);

            if (aspnetuser != null)
                return GetClaim(claimName, aspnetuser.Id);
            else
                return string.Empty;
        }

        // Método auxiliar (asegúrate de que GetClaim esté implementado en tu proyecto)
        private string GetClaim(string claimName, string userId)
        {
            // Implementación de GetClaim según tu lógica existente
            return string.Empty; // Placeholder
        }

        [HttpGet("GetInformacionUsuario/{userName}")]
        public async Task<ActionResult<ApiResponse>> BuscarInfoUsuario(string userName)
        {
            var _ApiResponse = new ApiResponse();

            try
            {
                var Usuario =  await _dbContext.AspNetUsers
                                    .FirstOrDefaultAsync(b => b.UserName == userName);

                if (Usuario == null)
                {
                    _ApiResponse.IsExitoso = false;
                    _ApiResponse.statusCode = HttpStatusCode.NotFound;
                    _ApiResponse.ErrorMessages = new List<string>() { $"El usuario con el nombre de usuario {userName} no fue encontrado" };
                    return NotFound(_ApiResponse);
                }

                var InformacionUsuario = new
                {
                    userName = Usuario.UserName,
                    NombreUsuario = Usuario.Name,
                    UsuarioID = Usuario.Id
                };

                _ApiResponse.statusCode = HttpStatusCode.OK;
                _ApiResponse.IsExitoso = true;
                _ApiResponse.Result = InformacionUsuario;

                return Ok(_ApiResponse);

            }
            catch(Exception ex)
            {
                _ApiResponse.IsExitoso = false;
                _ApiResponse.statusCode = HttpStatusCode.BadRequest;
                _ApiResponse.ErrorMessages = new List<string>() { "Error al obtener los datos del usuario logueado en Zismed.", ex.ToString() };

                return StatusCode((int)_ApiResponse.statusCode, _ApiResponse);
            }

            
        }
    }
}
