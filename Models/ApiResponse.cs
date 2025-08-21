using System.Net;
using System.Runtime.InteropServices.ObjectiveC;

namespace Zismed_Apis.Models
{
    public class ApiResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsExitoso { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
