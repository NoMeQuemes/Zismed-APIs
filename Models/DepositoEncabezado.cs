using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DepositoEncabezado
{
    public int EncabezadoId { get; set; }

    public int TipoMovimientoId { get; set; }

    public string NumeroReferencia { get; set; } = null!;

    public int SectorDestinoId { get; set; }

    public int ProveedorId { get; set; }

    public DateOnly FechaMovimiento { get; set; }

    public string Hora { get; set; } = null!;

    public string Operador { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<DepositoDetalle> DepositoDetalle { get; set; } = new List<DepositoDetalle>();

    public virtual Proveedores Proveedor { get; set; } = null!;

    public virtual SectoresHospital SectorDestino { get; set; } = null!;

    public virtual DepositoTipoMovimiento TipoMovimiento { get; set; } = null!;
}
