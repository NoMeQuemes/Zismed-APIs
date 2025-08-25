using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarSucursales
{
    public int SucursalId { get; set; }

    public string Nombre { get; set; } = null!;

    public string PuntoVenta { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<FarEncabezadoCompras> FarEncabezadoCompras { get; set; } = new List<FarEncabezadoCompras>();

    public virtual ICollection<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezadoSucursalDestino { get; set; } = new List<FarRemitoTemporalEncabezado>();

    public virtual ICollection<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezadoSucursalOrigen { get; set; } = new List<FarRemitoTemporalEncabezado>();

    public virtual ICollection<FarmaciaSucursalXusuario> FarmaciaSucursalXusuario { get; set; } = new List<FarmaciaSucursalXusuario>();
}
