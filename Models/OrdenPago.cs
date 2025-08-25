using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenPago
{
    public int OrdenPagoId { get; set; }

    public int? OrdenCompraId { get; set; }

    public int OrdenPagoEstadoId { get; set; }

    public int? CuentaBancariaId { get; set; }

    public int ProveedorId { get; set; }

    public decimal ImporteTotal { get; set; }

    public int NroOrdenPago { get; set; }

    public int? PresupuestoResolucionId { get; set; }

    public int? FondoPermanenteId { get; set; }

    public int? ExpedienteId { get; set; }

    public DateOnly FechaOrden { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? NroExpediente { get; set; }

    public int? NroAsiento { get; set; }

    public virtual CuentaBancaria? CuentaBancaria { get; set; }

    public virtual OrdenCompra? OrdenCompra { get; set; }

    public virtual ICollection<OrdenPagoAsiento> OrdenPagoAsiento { get; set; } = new List<OrdenPagoAsiento>();

    public virtual ICollection<OrdenPagoDetalle> OrdenPagoDetalle { get; set; } = new List<OrdenPagoDetalle>();

    public virtual OrdenPagoEstado OrdenPagoEstado { get; set; } = null!;

    public virtual ICollection<OrdenPagoEstadoHistorico> OrdenPagoEstadoHistorico { get; set; } = new List<OrdenPagoEstadoHistorico>();
}
