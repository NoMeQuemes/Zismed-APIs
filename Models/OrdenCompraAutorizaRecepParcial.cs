using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenCompraAutorizaRecepParcial
{
    public int OrdenCompraAutorizaRecepParcialId { get; set; }

    public int OrdenCompraId { get; set; }

    public DateTime FechaSolicita { get; set; }

    public string UsuarioSolicita { get; set; } = null!;

    public DateTime? FechaResuelve { get; set; }

    public string? UsuarioResuelve { get; set; }

    public DateTime? FechaRecepciona { get; set; }

    public string? UsuarioRecepciona { get; set; }

    public bool Autorizada { get; set; }

    public bool Rechazada { get; set; }

    public bool Recepcionada { get; set; }

    public bool Anulado { get; set; }
}
