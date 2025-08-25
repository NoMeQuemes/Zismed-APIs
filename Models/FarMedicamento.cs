using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarMedicamento
{
    public int FarMedicamentoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int FarTipoMedicamentoId { get; set; }

    public string? Presentacion { get; set; }

    public bool Anulado { get; set; }

    public virtual FarTipoMedicamento FarTipoMedicamento { get; set; } = null!;

    public virtual ICollection<IndicacionesRegistroAplicacionDescartables> IndicacionesRegistroAplicacionDescartables { get; set; } = new List<IndicacionesRegistroAplicacionDescartables>();

    public virtual ICollection<MedicacionDiscreta> MedicacionDiscreta { get; set; } = new List<MedicacionDiscreta>();

    public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinua { get; set; } = new List<MedicacionInfusionContinua>();
}
