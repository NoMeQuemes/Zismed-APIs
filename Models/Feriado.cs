using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Feriado
{
    public int FeriadoId { get; set; }

    public DateTime FeriadoFecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public string FeriadoHoraDesde { get; set; } = null!;

    public string FeriadoHoraHasta { get; set; } = null!;

    public int TipoFeriadoId { get; set; }

    public bool Anulado { get; set; }
}
