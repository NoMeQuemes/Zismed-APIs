using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnaemnesisObstetricia
{
    public int AnaemnesisObtetriciaId { get; set; }

    public int? AnaemnesisGeneralId { get; set; }

    public DateOnly? EmbarazoAnteriorFin { get; set; }

    public bool EmbarazoAnteriorMenos1anioMax5anios { get; set; }

    public bool? EmbarazoAnteriorPlaneado { get; set; }

    public int? EmbarazoAnteriorMetodoAnticonceptivo { get; set; }

    public decimal AntesEmbarazoPeso { get; set; }

    public int AntesEmbarazoTalla { get; set; }

    public DateOnly? AntesEmbarazoFum { get; set; }

    public DateOnly? AntesEmbarazoFpp { get; set; }

    public int? PresentacionFetal { get; set; }

    public bool? EgconfiableFum { get; set; }

    public bool? EgconfiableEcoMenor20Semanas { get; set; }

    public int? BacteriuriaMenorVeinteN { get; set; }

    public int? BacteriuriaMayorVeinteN { get; set; }

    public string? GlucemiaMenosVeinteSemanas { get; set; }

    public string? GlucemiaMayorTreintaSemanas { get; set; }

    public int? EstreptoB35a37SemanasP { get; set; }

    public bool? PreparacionParto { get; set; }

    public bool? ConcejeriaLactancia { get; set; }

    public int? AlturaPesoPresentacionFeto { get; set; }

    public string? AlturaPesoTamanoFetal { get; set; }

    public int AlturaPesoFrecuenciaCardiacaFetal { get; set; }

    public bool AlturaPesoContracionUterina { get; set; }

    public bool? AlturaPesoTonoNormal { get; set; }

    public int? AlturaPesoDiagnosticoPresuntivoId { get; set; }

    public string? AlturaPesoDiagnosticoPresuntivo { get; set; }

    public byte AntecedentesObstetricosGesta { get; set; }

    public byte AntecedentesObstetricosInmaduros { get; set; }

    public byte AntecedentesObstetricosVivos { get; set; }

    public byte AntecedentesObstetricosAbortos { get; set; }

    public byte AntecedentesObstetricosVaginales { get; set; }

    public byte AntecedentesObstetricosMuertos { get; set; }

    public byte AntecedentesObstetricosPartos { get; set; }

    public byte AntecedentesObstetricosCesareas { get; set; }

    public bool? AntecedentesObstetricosComplicaciones { get; set; }

    public string? AntecedentesObstetricosObservaciones { get; set; }

    public bool? AntecedentesObstetricosPap { get; set; }

    public bool? AntecedentesObstetricosPelvisNormal { get; set; }

    public bool? AntecedentesObstetricosEstudios { get; set; }

    public virtual Cie10? AlturaPesoDiagnosticoPresuntivoNavigation { get; set; }

    public virtual TipoPresentacionAlturaFeto? AlturaPesoPresentacionFetoNavigation { get; set; }

    public virtual AnaemnesisGeneral? AnaemnesisGeneral { get; set; }

    public virtual TipoNormalAnormal? BacteriuriaMayorVeinteNNavigation { get; set; }

    public virtual TipoNormalAnormal? BacteriuriaMenorVeinteNNavigation { get; set; }

    public virtual MetodoAnticonceptivo? EmbarazoAnteriorMetodoAnticonceptivoNavigation { get; set; }

    public virtual TipoPositivoNegativo? EstreptoB35a37SemanasPNavigation { get; set; }

    public virtual TipoPresentacionFetal? PresentacionFetalNavigation { get; set; }
}
