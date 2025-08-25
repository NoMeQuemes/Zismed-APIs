using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DetalleIngresoEgreso
{
    public int DetalleId { get; set; }

    public int IngresoEgresoId { get; set; }

    public int ProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public int? PedIntDetalleRetirarId { get; set; }

    public string? UsuarioEntrega { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public bool? NoEntregado { get; set; }

    public int? DepositoId { get; set; }

    public virtual DepositoIngresoEgreso IngresoEgreso { get; set; } = null!;

    public virtual Productos Producto { get; set; } = null!;
}
