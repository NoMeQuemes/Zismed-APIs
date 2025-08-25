using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LabRegistroResultadosLog
{
    public int LabRegistroResultadosLogId { get; set; }

    public int LabRegistroDetalleId { get; set; }

    public string? Resultado { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public bool ResultadoEditado { get; set; }

    public bool Impreso { get; set; }

    public bool PedidoAnulado { get; set; }

    public bool PedidoNuevo { get; set; }

    public DateTime? FechaConfirma { get; set; }

    public virtual LabRegistroDetalle LabRegistroDetalle { get; set; } = null!;
}
