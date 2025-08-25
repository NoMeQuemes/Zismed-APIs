using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ResultadosInformes
{
    public int ResultadoInformeId { get; set; }

    public int EncabezadoId { get; set; }

    public int? Iddat { get; set; }

    public string? Valor { get; set; }

    public DateTime? Fecha { get; set; }

    public string UsuarioId { get; set; } = null!;

    public int? Idarq { get; set; }

    public int? Idtipodato { get; set; }
}
