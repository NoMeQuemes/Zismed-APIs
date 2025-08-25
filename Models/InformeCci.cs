using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InformeCci
{
    public int InformeCciid { get; set; }

    public string? TipoCaso { get; set; }

    public DateOnly? FechaInicioSintomas { get; set; }

    public bool? Disnea { get; set; }

    public bool? Tos { get; set; }

    public bool? DolorGarganta { get; set; }

    public bool? PerdidaGusto { get; set; }

    public bool? PerdidaOlfato { get; set; }

    public bool? Cefalea { get; set; }

    public bool? Diarrea { get; set; }

    public bool? Vomitos { get; set; }

    public string? OtrosSintomas { get; set; }

    public bool? Dbt { get; set; }

    public bool? Erc { get; set; }

    public bool? Cardiop { get; set; }

    public bool? Hta { get; set; }

    public bool? Epoc { get; set; }

    public string? OtrasEnfermedades { get; set; }

    public DateOnly? FechaContacto { get; set; }

    public string? TipoContacto { get; set; }

    public bool? EsPersonalSalud { get; set; }

    public bool? ResideInstitucionCerrada { get; set; }

    public bool? EsPersonalEsencial { get; set; }

    public bool? ResidentePuebloOriginario { get; set; }

    public bool? RetornaDeViaje { get; set; }

    public bool? ResidenteBarrioPopular { get; set; }

    public bool? ContactoCuadroRespiratorio { get; set; }

    public bool? ContactoViajero { get; set; }

    public string? ObservacionNexoEpidem { get; set; }

    public string? NivelConciencia { get; set; }

    public bool? OxigenoTerapia { get; set; }

    public int? Curb65 { get; set; }

    public int? News2 { get; set; }

    public bool? AislamientoDom { get; set; }

    public int? NroConvivientes { get; set; }

    public bool? RayosTorax { get; set; }

    public string? Hisopado { get; set; }

    public string? InternacionDerivacion { get; set; }

    public int? PrestadorId { get; set; }

    public string? ObservacionesDefinicionCaso { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateOnly? FechaCrea { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateOnly? FechaModifica { get; set; }

    public bool? Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateOnly? FechaAnula { get; set; }

    public int AnaemnesisReducidaId { get; set; }

    public string? DerivaDe { get; set; }

    public decimal? Imc { get; set; }

    public DateOnly? PositivoDesde { get; set; }
}
