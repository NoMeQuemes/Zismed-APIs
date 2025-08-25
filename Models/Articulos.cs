using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Articulos
{
    public int NroRegistro { get; set; }

    public string? Troquel { get; set; }

    public string Nombre { get; set; } = null!;

    public string Presentacion { get; set; } = null!;

    public string? Codbarras { get; set; }

    public decimal? Precio { get; set; }

    public string? Heladera { get; set; }

    public int? Formas { get; set; }

    public decimal? PrecioCompra { get; set; }

    public DateOnly? FechaUltCompra { get; set; }

    public decimal? Iva { get; set; }

    public string Articulo { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<DepositoDetalle> DepositoDetalle { get; set; } = new List<DepositoDetalle>();
}
