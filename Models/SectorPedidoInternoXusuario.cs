using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SectorPedidoInternoXusuario
{
    public int SectorPedidoInternoXusuarioId { get; set; }

    public string UserId { get; set; } = null!;

    public int PedidoSectorId { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaAnulado { get; set; }

    public string? UsuarioCreacion { get; set; }

    public string? UsuarioAnulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual PedidoSector PedidoSector { get; set; } = null!;
}
