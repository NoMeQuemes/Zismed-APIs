using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class UsuarioXdeposito
{
    public int UsuarioDepositoId { get; set; }

    public string? UserId { get; set; }

    public int? DepositoId { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioCreacion { get; set; }
}
