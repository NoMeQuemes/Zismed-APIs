using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VwManualDatCobertura
{
    public DateOnly? Expr1 { get; set; }

    public int NroRegistro { get; set; }

    public string Troquel { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Presentacion { get; set; } = null!;

    public string Laboratorio { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Fecha { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string? Registro { get; set; }

    public string CodBarras { get; set; } = null!;

    public decimal CoberturaAmbulatorio { get; set; }

    public decimal CoberturaInternado { get; set; }

    public string Baja { get; set; } = null!;

    public string Tamano { get; set; } = null!;
}
