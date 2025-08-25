using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoMovimientos
{
    public int IdMovimiento { get; set; }

    public int IdIngresoNodo { get; set; }

    public int DesdeCamaId { get; set; }

    public int HastaCamaId { get; set; }

    public bool Activo { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string? Motivo { get; set; }

    public virtual Camas DesdeCama { get; set; } = null!;

    public virtual Camas HastaCama { get; set; } = null!;
}
