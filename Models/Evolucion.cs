using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Evolucion
{
    public int EvolucionId { get; set; }

    public int InternacionId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaEvolucion { get; set; }

    public int PrestadorId { get; set; }

    public bool Anulado { get; set; }

    public string DetalleEvolucion { get; set; } = null!;

    public int? MovimientoInternadoId { get; set; }

    public virtual Internaciones Internacion { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;
}
