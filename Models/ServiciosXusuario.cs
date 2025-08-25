using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ServiciosXusuario
{
    public int ServiciosXusuarioId { get; set; }

    public string UserId { get; set; } = null!;

    public int ServicioId { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaAnulado { get; set; }

    public string? UsuarioCreacion { get; set; }

    public string? UsuarioAnulado { get; set; }

    public string? RolId { get; set; }

    public int? ServiciosXusuarioIdoriginal { get; set; }

    public int? InstitucionId { get; set; }
}
