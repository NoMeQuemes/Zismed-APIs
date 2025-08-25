using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DepositoIngresoEgreso
{
    public int IngresoEgresoId { get; set; }

    public DateTime Fecha { get; set; }

    public string? Ncomprobante { get; set; }

    public int? ProveedorId { get; set; }

    public decimal? Monto { get; set; }

    public string Usuario { get; set; } = null!;

    public bool IngresoOegreso { get; set; }

    public string? Nexpediente { get; set; }

    public DateOnly? FechaExpediente { get; set; }

    public int? PedidoSectorId { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Observaciones { get; set; }

    public int? DepositoIeestadoId { get; set; }

    public int? DepositoId { get; set; }

    public int? PedidoInternoId { get; set; }

    public int? NotaPedidoId { get; set; }

    public int? OrdenCompraId { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public string? UsuarioId { get; set; }

    public virtual ICollection<DepositoIeestadoHistorico> DepositoIeestadoHistorico { get; set; } = new List<DepositoIeestadoHistorico>();

    public virtual ICollection<DetalleIngresoEgreso> DetalleIngresoEgreso { get; set; } = new List<DetalleIngresoEgreso>();

    public virtual EmpleadosHospital? Empleado { get; set; }

    public virtual PedidoSector? PedidoSector { get; set; }

    public virtual Proveedores? Proveedor { get; set; }
}
