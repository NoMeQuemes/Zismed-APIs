using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoGoteo
{
    public int TipoGoteoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinua { get; set; } = new List<MedicacionInfusionContinua>();

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();
}
