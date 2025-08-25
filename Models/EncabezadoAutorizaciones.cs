using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EncabezadoAutorizaciones
{
    public int AutorizacionesId { get; set; }

    public int IdAfiliado { get; set; }

    public int IdPlan { get; set; }

    public int? IdInternadoIosep { get; set; }

    public string Numero { get; set; } = null!;

    public string? NumeroInternacion { get; set; }

    public short IdDelegacion { get; set; }

    public int IdMedicoPrescriptor { get; set; }

    public int? IdEfector { get; set; }

    public int? IdInstitucion { get; set; }

    public int IdDiagnostico { get; set; }

    public DateOnly FechaPrescripcion { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string Operador { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? MotivoRechazo { get; set; }

    /// <summary>
    /// P - &apos; &apos; Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada
    /// </summary>
    public string EstadoAutorizacion { get; set; } = null!;

    public bool Anulada { get; set; }

    public string? OperAnula { get; set; }

    public DateTime? Modifica { get; set; }

    public bool IosepSalud { get; set; }

    public byte IdLugar { get; set; }

    public bool? Marca { get; set; }

    public bool? Remiso { get; set; }

    public DateTime? FechaRemiso { get; set; }

    public string? OperRemiso { get; set; }

    public bool? RemisoCobrado { get; set; }

    public bool FueraProvincia { get; set; }

    public int CartaPresentacionId { get; set; }

    public int? IdGrupoPractica { get; set; }

    public int? IdCentroAfiliado { get; set; }

    public int? IdCentroImpresion { get; set; }

    public bool? CambioCentro { get; set; }

    public int? IdDelegacionImp { get; set; }

    public string? UsuarioImprime { get; set; }

    public DateTime? FechaImprime { get; set; }

    public int InternacionId { get; set; }

    public int? IdAutorizacionIosep { get; set; }

    public virtual ICollection<DetalleAutorizaciones> DetalleAutorizaciones { get; set; } = new List<DetalleAutorizaciones>();
}
