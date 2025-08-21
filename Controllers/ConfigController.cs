using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//Configuración de plantillas y órdenes rápidas (por servicio o usuario):
//GET /config/ordenes-rapidas
//GET / config / plantillas
namespace Zismed_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
    }
}
