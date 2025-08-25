using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEstadoMedicacionPacienteDetalle
{
    public int TipoEstadoMedicacionPacienteDetalleId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<MedicacionPacienteDetalle> MedicacionPacienteDetalle { get; set; } = new List<MedicacionPacienteDetalle>();
}
