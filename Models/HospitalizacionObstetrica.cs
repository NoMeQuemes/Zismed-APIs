using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HospitalizacionObstetrica
{
    public int IdHospitalizacionObst { get; set; }

    public int IdHospitalizacion { get; set; }

    public DateOnly? FechaTermEmbarazo { get; set; }

    public int? EdadGestacional { get; set; }

    public int? Paridad { get; set; }

    public int? TipoParto { get; set; }

    public string? MalformGeneticaSinDet { get; set; }

    public string? MalformGeneticaSinIndet { get; set; }

    public string? MalformCongenita { get; set; }

    public virtual ICollection<HospitalizacionObstetricaDetalle> HospitalizacionObstetricaDetalle { get; set; } = new List<HospitalizacionObstetricaDetalle>();

    public virtual Hospitalizacion IdHospitalizacionNavigation { get; set; } = null!;
}
