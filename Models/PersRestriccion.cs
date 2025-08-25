using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersRestriccion
{
    public int PersRestriccionId { get; set; }

    public string? Detalle { get; set; }

    public string? Tipo { get; set; }

    public string? Antiguedad { get; set; }

    public int? Nuevamente { get; set; }

    public string? Prorroga { get; set; }

    public decimal? Horas { get; set; }

    public int? DiasMax { get; set; }

    public int? MesMax { get; set; }

    public int? TopeMensualDias { get; set; }

    public int? TopeAnualDias { get; set; }

    public int? TopeMensualPermisos { get; set; }

    public int? TopeAnualPermisos { get; set; }

    public int? DiasAnticipacion { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public bool SoloHabiles { get; set; }

    public bool Divisible { get; set; }

    public int? CargaHorariaMinimaDiaria { get; set; }
}
