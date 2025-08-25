using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PlanillaControl
{
    public int IdControl { get; set; }

    public int OftalmologiaId { get; set; }

    public bool? Anual { get; set; }

    public bool? Nmeses { get; set; }

    public bool? Cmeses { get; set; }

    public bool? Dtmeses { get; set; }

    public bool? Umes { get; set; }

    public bool? Retinopatia { get; set; }

    public bool? ProlifLeve { get; set; }

    public bool? ProlifModerada { get; set; }

    public bool? ProlifSevera { get; set; }

    public bool? Proliferativa { get; set; }

    public bool? Indicacion { get; set; }

    public bool? Laser { get; set; }

    public bool? Vitrectomia { get; set; }

    public bool? Cirugia { get; set; }

    public bool? Cataratas { get; set; }

    public bool? EdemaMacular { get; set; }

    public bool? Glaucoma { get; set; }

    public bool? HemorragiaVitrea { get; set; }

    public string? Otros { get; set; }

    public bool? Anulado { get; set; }

    public int? PrestadorId { get; set; }

    public virtual Oftalmologia Oftalmologia { get; set; } = null!;

    public virtual Prestadores? Prestador { get; set; }
}
