using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnaemnesisGeneral
{
    public int AnaemnesisGeneralId { get; set; }

    public int AnaemnesisId { get; set; }

    public string? Domicilio { get; set; }

    public string? Profesion { get; set; }

    public int? PersonalEtniaId { get; set; }

    public bool? PersonalAlfabeta { get; set; }

    public int? PersonalTipoInstruccionId { get; set; }

    public byte? PersonalAniosMayorNivelEstudios { get; set; }

    public int? PersonalEstadoCivil { get; set; }

    public bool? PersonalViveSola { get; set; }

    public string? PersonalOcupacion { get; set; }

    public bool? FamiliarDiabetes { get; set; }

    public bool? FamiliarTbc { get; set; }

    public bool? FamiliarHipertencion { get; set; }

    public bool? FamiliarGemelares { get; set; }

    public string? FamiliarOtros { get; set; }

    public bool? PersonalesHiv { get; set; }

    public bool? PersonalesHepatitis { get; set; }

    public bool? PersonalesDiabetes { get; set; }

    public bool? PersonalesTbc { get; set; }

    public bool? PersonalesHipertencion { get; set; }

    public bool? PersonalesCirugiaPu { get; set; }

    public bool? PersonalesMedicacion { get; set; }

    public bool? PersonalesChagas { get; set; }

    public bool? PersonalesToxoplasmosis { get; set; }

    public bool? PersonalesSifilis { get; set; }

    public bool? PersonalesRubeola { get; set; }

    public bool? PersonalesCmv { get; set; }

    public bool? PersonalesInfertilidad { get; set; }

    public bool? PersonalesAlergias { get; set; }

    public string? PersonalesOtros { get; set; }

    public bool? PersonalesAntitetanica { get; set; }

    public bool? PersonalesPrimeraDosis { get; set; }

    public bool? PersonalesSegundaDosis { get; set; }

    public bool? PersonalesFuma { get; set; }

    public byte? PersonalesCantidadCigarros { get; set; }

    public bool? PersonalesAlcohol { get; set; }

    public decimal? PersonalesPeso { get; set; }

    public decimal? PersonalesTemperatura { get; set; }

    public int? PersonalesPulso { get; set; }

    public int? PersonalesTensionArterialMaxima { get; set; }

    public int? PersonalesTensionArterialMinima { get; set; }

    public int? PersonalesAmenorrea { get; set; }

    public int? FisicoGeneralCabezaCuelloN { get; set; }

    public string? FisicoGeneralOtros { get; set; }

    public int? FisicoGeneralAparatoRespiratorioN { get; set; }

    public bool? FisicoGeneralBeba { get; set; }

    public bool? FisicoGeneralMv { get; set; }

    public bool? FisicoGeneralVv { get; set; }

    public string? FisicoGeneralOtrosDetalle { get; set; }

    public int? FisicoGeneralAparatoCardiovascularN { get; set; }

    public int? FisicoGeneralR3 { get; set; }

    public int? FisicoGeneralR4 { get; set; }

    public string? FisicoGeneralOtrosCardiologicos { get; set; }

    public bool? FisicoGeneralAparatoUrinarioPprb { get; set; }

    public bool? FisicoGeneralAparatoUrinarioDisuria { get; set; }

    public string? FisicoGeneralAparatoUrinarioOtrosOrina { get; set; }

    public int? FisicoGeneralMiembroSuperiorN { get; set; }

    public string? FisicoGeneralOtrosMiembroSuperior { get; set; }

    public int? FisicoGeneralMiembroInferiorN { get; set; }

    public string? FisicoGeneralOtrosMiembroInferior { get; set; }

    public bool? FisicoGeneralTipoAbdomenBlando { get; set; }

    public bool? FisicoGeneralTipoAbdomenDistendido { get; set; }

    public bool? FisicoGeneralTipoAbdomenDoloroso { get; set; }

    public bool? FisicoGeneralTipoAbdomenRma { get; set; }

    public bool? FisicoGeneralTipoAbdomenCatarsis { get; set; }

    public bool? FisicoGeneralTipoAbdomenGestante { get; set; }

    public bool? FisicoGeneralTipoAbdomenEliminaGases { get; set; }

    public bool? FisicoGeneralTipoAbdomenMaf { get; set; }

    public int? FisicoGeneralTipoAbdomenLcf { get; set; }

    public bool? FisicoGeneralTipoAbdomenEntregoEstudios { get; set; }

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual Anamnesis Anaemnesis { get; set; } = null!;

    public virtual ICollection<AnaemnesisObstetricia> AnaemnesisObstetricia { get; set; } = new List<AnaemnesisObstetricia>();

    public virtual ICollection<AnalisisSocioEconomico> AnalisisSocioEconomico { get; set; } = new List<AnalisisSocioEconomico>();

    public virtual ICollection<AnemnesisPuerperio> AnemnesisPuerperio { get; set; } = new List<AnemnesisPuerperio>();

    public virtual TipoNormalAlterado? FisicoGeneralAparatoCardiovascularNNavigation { get; set; }

    public virtual TipoNormalAlterado? FisicoGeneralAparatoRespiratorioNNavigation { get; set; }

    public virtual TipoNormalAlterado? FisicoGeneralCabezaCuelloNNavigation { get; set; }

    public virtual TipoNormalAlterado? FisicoGeneralMiembroInferiorNNavigation { get; set; }

    public virtual TipoNormalAlterado? FisicoGeneralMiembroSuperiorNNavigation { get; set; }

    public virtual TipoOsculta? FisicoGeneralR3Navigation { get; set; }

    public virtual TipoOsculta? FisicoGeneralR4Navigation { get; set; }

    public virtual EstadoCivil? PersonalEstadoCivilNavigation { get; set; }

    public virtual TipoEtnia? PersonalEtnia { get; set; }

    public virtual TipoInstruccion? PersonalTipoInstruccion { get; set; }
}
