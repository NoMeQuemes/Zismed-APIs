using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//Manjea el ciclo de vida de la consulta/borrador:
//POST /consultas/draft → Crear borrador.
//PUT /consultas/{id}/autosave → Guardar evolución, indicaciones, diagnósticos, órdenes (autosave).
//POST /consultas/{id}/acciones/{accion} → Alta, derivar, cerrar, etc.
namespace Zismed_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ConsultasController : ControllerBase
    {
    }
}
