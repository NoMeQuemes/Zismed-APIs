using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VwTurnosDetalle
{
    public int PrestadorId { get; set; }

    public int ServicioId { get; set; }

    public DateTime FechaHora { get; set; }

    public DateTime? Llegada { get; set; }

    public DateTime? Llamado { get; set; }

    public DateTime? Atendido { get; set; }

    public bool Anulado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Expr1 { get; set; } = null!;

    public int ConsultorioId { get; set; }

    public int PacienteId { get; set; }

    public string Expr2 { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string Expr3 { get; set; } = null!;
}
