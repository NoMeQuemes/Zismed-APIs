using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedicacionInfusionContinuaDetalle
{
    public int MedicacionInfusionContinuaDetalleId { get; set; }

    public int MedicacionInfusionContinuaId { get; set; }

    public int? FarMedicamentoId { get; set; }

    public int? NuevaDro { get; set; }

    public int? MultiDro { get; set; }

    public int? NroRegistro { get; set; }

    public string MedPresentacion { get; set; } = null!;

    public string MedNombre { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public DateTime? FechaRetira { get; set; }

    public int? PrestadorIdretira { get; set; }

    public string? CodigoTubo { get; set; }

    public string? UsuarioCargaCodigoTubo { get; set; }

    public DateTime? FechaCargaCodigoTubo { get; set; }

    public virtual MedicacionInfusionContinua MedicacionInfusionContinua { get; set; } = null!;
}
