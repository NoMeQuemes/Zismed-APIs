using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Hospital
{
    public int HospitalId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Jurisdiccion { get; set; }

    public string? Programa { get; set; }

    public string? ProgramaDescripcion { get; set; }

    public virtual ICollection<HospitalActividad> HospitalActividad { get; set; } = new List<HospitalActividad>();

    public virtual ICollection<HospitalProyecto> HospitalProyecto { get; set; } = new List<HospitalProyecto>();

    public virtual ICollection<HospitalSubPrograma> HospitalSubPrograma { get; set; } = new List<HospitalSubPrograma>();

    public virtual ICollection<PresupuestoAnual> PresupuestoAnual { get; set; } = new List<PresupuestoAnual>();
}
