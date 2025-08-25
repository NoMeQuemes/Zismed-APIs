using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaIngresoDetalle
{
    public int FarmaciaIngresoDetalleId { get; set; }

    public int FarmaciaIngresoId { get; set; }

    public int FarmaciaArticuloId { get; set; }

    public int? NroRegistro { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioCosto { get; set; }

    public decimal Impuestos { get; set; }

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

    public int? FarmaciaArticuloAnteriorId { get; set; }

    public virtual ArticulosFarmaciaCis FarmaciaArticulo { get; set; } = null!;

    public virtual FarmaciaIngreso FarmaciaIngreso { get; set; } = null!;
}
