﻿using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarDetalleCompras
{
    public int IdDetalleCompra { get; set; }

    public int IdEncabezadoCompra { get; set; }

    public int NroRegistro { get; set; }

    public string Articulo { get; set; } = null!;

    public string? Gtin { get; set; }

    public string? Codbarras { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioCosto { get; set; }

    public decimal? Impuestos { get; set; }

    public bool? Trazado { get; set; }

    public string? Lote { get; set; }

    public string? Vence { get; set; }

    public string? OpCrea { get; set; }

    public DateTime? Crea { get; set; }

    public string? OpModi { get; set; }

    public DateTime? Modi { get; set; }

    public bool Anulado { get; set; }
}
