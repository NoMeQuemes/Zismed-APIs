using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//Expone información clínica resumida y eventos:
//GET /pacientes/{id}/resumen → Datos básicos, alergias, crónicos, triage.
//GET /pacientes/{id}/timeline → Eventos clínicos recientes.
namespace Zismed_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {

    }
}