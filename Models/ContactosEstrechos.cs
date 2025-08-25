using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ContactosEstrechos
{
    public int ContactoEstrechoId { get; set; }

    public string ApellidoNombre { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Domicilio { get; set; }

    public DateOnly FechaUltimoContacto { get; set; }

    public byte TipoContacto { get; set; }

    public int NotificacionId { get; set; }

    public bool? Anulado { get; set; }

    public virtual NotificacionesCovid Notificacion { get; set; } = null!;
}
