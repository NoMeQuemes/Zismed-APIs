using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaEgresoDetalle
{
    public int FarmaciaEgresoDetalleId { get; set; }

    public int FarmaciaEgresoId { get; set; }

    public int ArticuloFarmaciaCisId { get; set; }

    public int? NroRegistro { get; set; }

    public decimal Cantidad { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public string? Lote { get; set; }

    public string? Gtin { get; set; }

    public string? CodBarras { get; set; }

    public bool Trazado { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual ArticulosFarmaciaCis ArticuloFarmaciaCis { get; set; } = null!;

    public virtual FarmaciaEgreso FarmaciaEgreso { get; set; } = null!;
}
