using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomExpedienteDetalle
{
    public int NomExpedienteDetalleId { get; set; }

    public int NomExpedienteId { get; set; }

    public int NomServicioId { get; set; }

    public string? NomServicioNombre { get; set; }

    public int NomencladorId { get; set; }

    public string? Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public int? NomLaboratorioId { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaPractica { get; set; }

    public decimal? Porcentaje { get; set; }

    public int? LoteRegPagoId { get; set; }

    public bool? PagoParcial { get; set; }

    public bool? Pagado { get; set; }

    public virtual NomServicios NomServicio { get; set; } = null!;

    public virtual Nomenclador Nomenclador { get; set; } = null!;
}
