using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Epicrisis
{
    public int EpicrisisId { get; set; }

    public int InternacionId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaEpicrisis { get; set; }

    public int PrestadorId { get; set; }

    public bool Anulado { get; set; }

    public string DetalleEpicrisis { get; set; } = null!;

    public string? Upa { get; set; }

    public DateTime? FechaUpa { get; set; }

    public string? Hospital { get; set; }

    public DateTime? FechaHospital { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<EpicrisisDetalle> EpicrisisDetalle { get; set; } = new List<EpicrisisDetalle>();

    public virtual Internaciones Internacion { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;
}
