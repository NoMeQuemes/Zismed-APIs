using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarRemitoTemporalEncabezado
{
    public int IdEncabezadoTemporal { get; set; }

    public string Numero { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public int SucursalOrigenId { get; set; }

    public int SucursalDestinoId { get; set; }

    public int EstadoId { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime? Crea { get; set; }

    public string? OpModi { get; set; }

    public DateTime? Modi { get; set; }

    public DateOnly? FechaRecibido { get; set; }

    public string? HoraRecibido { get; set; }

    public bool? RecibidoFaltantes { get; set; }

    public bool Anulado { get; set; }

    public virtual TipoEstadoRemito Estado { get; set; } = null!;

    public virtual ICollection<FarRemitoTemporalDetalle> FarRemitoTemporalDetalle { get; set; } = new List<FarRemitoTemporalDetalle>();

    public virtual FarSucursales SucursalDestino { get; set; } = null!;

    public virtual FarSucursales SucursalOrigen { get; set; } = null!;
}
