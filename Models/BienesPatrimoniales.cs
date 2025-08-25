using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class BienesPatrimoniales
{
    public int BienPatrimonialId { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public string CodHospital { get; set; } = null!;

    public string NumeroSerie { get; set; } = null!;

    public int SectorId { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public bool Anulado { get; set; }

    public int InstitucionId { get; set; }

    public virtual ICollection<BienPatrimonialMovimientos> BienPatrimonialMovimientos { get; set; } = new List<BienPatrimonialMovimientos>();

    public virtual SectoresHospital Sector { get; set; } = null!;
}
