using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadoresServicios
{
    public int PrestadoresServiciosId { get; set; }

    public int PrestadorId { get; set; }

    public int ServicioId { get; set; }

    public bool Anulado { get; set; }

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual Servicios Servicio { get; set; } = null!;
}
