using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FondoPermanente
{
    public int FondoPermanenteId { get; set; }

    public int ProveedorId { get; set; }

    public int FondoPermanenteEstadoId { get; set; }

    public string NroComprobante { get; set; } = null!;

    public decimal ImporteTotal { get; set; }

    public DateOnly FechaComprobante { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public bool Anulado { get; set; }

    public virtual FondoPermanenteEstado FondoPermanenteEstado { get; set; } = null!;
}
