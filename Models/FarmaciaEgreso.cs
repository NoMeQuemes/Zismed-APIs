using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaEgreso
{
    public int FarmaciaEgresoId { get; set; }

    public int FarTipoEgresoId { get; set; }

    public int FarmaciaDepositoId { get; set; }

    public int? PacienteId { get; set; }

    public int? MedicacionPacienteId { get; set; }

    public string? NumeroEgreso { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public int? SectorId { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Observaciones { get; set; }

    public int? PedidoInternoFarmaciaId { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual FarTipoEgreso FarTipoEgreso { get; set; } = null!;

    public virtual FarmaciaDeposito FarmaciaDeposito { get; set; } = null!;

    public virtual ICollection<FarmaciaEgresoDetalle> FarmaciaEgresoDetalle { get; set; } = new List<FarmaciaEgresoDetalle>();
}
