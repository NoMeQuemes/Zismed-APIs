using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaIngreso
{
    public int FarmaciaIngresoId { get; set; }

    public int FarmaciaDepositoId { get; set; }

    public int? ProveedorId { get; set; }

    public int FarTipoIngresoId { get; set; }

    public int FarTipoComprobanteId { get; set; }

    public string? NumeroIngreso { get; set; }

    public string NumeroComprobante { get; set; } = null!;

    public string? Caicomprobante { get; set; }

    public string? Gnl { get; set; }

    public DateTime FechaHoraRecepcion { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual FarTipoComprobante FarTipoComprobante { get; set; } = null!;

    public virtual FarTipoIngreso FarTipoIngreso { get; set; } = null!;

    public virtual FarmaciaDeposito FarmaciaDeposito { get; set; } = null!;

    public virtual ICollection<FarmaciaIngresoDetalle> FarmaciaIngresoDetalle { get; set; } = new List<FarmaciaIngresoDetalle>();

    public virtual Proveedores? Proveedor { get; set; }
}
