using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoSector
{
    public int PedidoSectorId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<DepositoIngresoEgreso> DepositoIngresoEgreso { get; set; } = new List<DepositoIngresoEgreso>();

    public virtual ICollection<PedidoInternoDestinos> PedidoInternoDestinos { get; set; } = new List<PedidoInternoDestinos>();

    public virtual ICollection<SectorPedidoInternoXusuario> SectorPedidoInternoXusuario { get; set; } = new List<SectorPedidoInternoXusuario>();
}
