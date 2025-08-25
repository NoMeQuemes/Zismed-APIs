using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnalisisSocioEconomico
{
    public int SocioEconomicoId { get; set; }

    public int AnemnesisGeneralId { get; set; }

    public int PacienteId { get; set; }

    public string? Solicita { get; set; }

    public int? DiagnosticoId { get; set; }

    public string? Ocupacion { get; set; }

    public string? DomicilioReal { get; set; }

    public string? PersonaReferencia { get; set; }

    public string? TelefonoReferencia { get; set; }

    public string? Observaciones { get; set; }

    public int? TipoCasaId { get; set; }

    public string? ObservacionesCasa { get; set; }

    public int? TipoTenenciaVivId { get; set; }

    public int? TipoMateriaConsId { get; set; }

    public short? AmbientesDormitorio { get; set; }

    public bool? AmbientesBaño { get; set; }

    public bool? AmbientesCocina { get; set; }

    public string? AmbientesOtros { get; set; }

    public bool? ServiciosLuzElectrica { get; set; }

    public bool? ServiciosGas { get; set; }

    public bool? ServiciosAguaCorriente { get; set; }

    public int? TipoZonaResidenciaId { get; set; }

    public string? OtrosDatos { get; set; }

    public string? ConsideracionesGenerales { get; set; }

    public byte? AdjuntaInformeSocioEconomico { get; set; }

    public byte? AdjuntaCetificadoAntecedentesMedicos { get; set; }

    public byte? AdjuntaPresupuestosCerrados { get; set; }

    public byte? AdjuntaPresupuestosAbiertos { get; set; }

    public string? ConstanciaObrasSocial { get; set; }

    public byte? NegativaAnses { get; set; }

    public byte? ConstanciaCuil { get; set; }

    public byte? AntecedentesSubsidios { get; set; }

    public byte? AutorizacionPolicialPcobrar { get; set; }

    public byte? CertificadoResidencia { get; set; }

    public byte? DeclaracionJuradaPolicial { get; set; }

    public byte? FotocopiaDocumento { get; set; }

    public byte? TotalFolios { get; set; }

    public int? PrestadorId { get; set; }

    public string? UsuarioId { get; set; }

    public virtual AnaemnesisGeneral AnemnesisGeneral { get; set; } = null!;

    public virtual TipoCasa? TipoCasa { get; set; }

    public virtual TipoMaterialConstruccion? TipoMateriaCons { get; set; }

    public virtual TipoTenenciaVivienda? TipoTenenciaViv { get; set; }

    public virtual TipoZonaResidencia? TipoZonaResidencia { get; set; }
}
