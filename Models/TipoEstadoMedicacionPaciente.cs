using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEstadoMedicacionPaciente
{
    public int TipoEstadoMedicacionPacienteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();
}
