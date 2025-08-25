using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DetalleAutorizaciones
{
    public int DetalleId { get; set; }

    public int AutorizacionesId { get; set; }

    public int IdNomenclador { get; set; }

    public byte CantidadSolicitada { get; set; }

    public byte CantidadAutorizada { get; set; }

    public decimal Honorarios { get; set; }

    public decimal Gastos { get; set; }

    public decimal CoseguroHonorarios { get; set; }

    public decimal CoseguroGastos { get; set; }

    public decimal ReconoceHonorarios { get; set; }

    public decimal ReconoceGastos { get; set; }

    public decimal? FacturaHonorarios { get; set; }

    public decimal? FacturaGastos { get; set; }

    public DateOnly? FechaPrestacion { get; set; }

    public int? IdEfector { get; set; }

    /// <summary>
    /// P - &apos; &apos; Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada
    /// </summary>
    public string EstadoAutorizacion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? MotivoRechazo { get; set; }

    public bool Anulada { get; set; }

    public string? MotivoAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? OperAnula { get; set; }

    public virtual EncabezadoAutorizaciones Autorizaciones { get; set; } = null!;
}
