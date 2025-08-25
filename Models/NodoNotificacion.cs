using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoNotificacion
{
    public int IdNotificacion { get; set; }

    public int IdIngresoNodo { get; set; }

    public int IdTipoFormulario { get; set; }

    public int IdFormulario { get; set; }

    public bool Revisado { get; set; }

    public string? UsuarioRevisa { get; set; }

    public DateTime? FechaRevisa { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? Observaciones { get; set; }
}
