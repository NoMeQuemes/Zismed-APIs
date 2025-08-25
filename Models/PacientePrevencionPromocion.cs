using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacientePrevencionPromocion
{
    public int PacientePrevPromId { get; set; }

    public int PacienteId { get; set; }

    public string? ObesidadImcmay30 { get; set; }

    public string? RastreoHta { get; set; }

    public string? ControlGlucemiaMenos1anio { get; set; }

    public string? ControlGlucemiaMas1anio { get; set; }

    public string? ControlGlucemiaNunca { get; set; }

    public string? ControlGlucemiaNsnc { get; set; }

    public string? ResultadoGlucemiaNormal { get; set; }

    public string? ResultadoGlucemiaAnormal { get; set; }

    public string? ResultadoGlucemiaDbt { get; set; }

    public string? ControlDislipemiaMenos1Anio { get; set; }

    public string? ControlDislipemiaMas1Anio { get; set; }

    public string? ControlDislipemiaNunca { get; set; }

    public string? ControlDislipemiaNsnc { get; set; }

    public string? ResultadoLipidicoNormal { get; set; }

    public string? ResultadoLipidicoAnormal { get; set; }

    public string? UltimoPapmenos1anio { get; set; }

    public string? UltimoPapmas1anio { get; set; }

    public string? UltimoPapnunca { get; set; }

    public string? UltimoPapnsnc { get; set; }

    public string? UltimoPapnoAplica { get; set; }

    public string? ResulUltimoPapnormal { get; set; }

    public string? ResulUltimoPapna { get; set; }

    public string? UltimaMamografiaMenos1anio { get; set; }

    public string? UltimaMamografiamas1anio { get; set; }

    public string? UltimaMamografiaNunca { get; set; }

    public string? UltimaMamografiaNsnc { get; set; }

    public string? UltimaMamografiaNoAplica { get; set; }

    public string? ResultadoMamografiaNormal { get; set; }

    public string? ResultadoMamografiaNa { get; set; }

    public string? UltimoSomfmenos1anio { get; set; }

    public string? UltimoSomfmas1Anio { get; set; }

    public string? UltimoSomfnunca { get; set; }

    public string? UltimoSomfnsnc { get; set; }

    public string? UltimoSomfnoAplica { get; set; }

    public string? ResultadoSomfnormal { get; set; }

    public string? ResultadoSomfna { get; set; }

    public string? Fuma { get; set; }

    public string? FumaDispuestoDejar { get; set; }

    public string? AlcoholismoCriticaFormaBeber { get; set; }

    public string? AlcoholismoImpresionDejarDeBeber { get; set; }

    public string? AlcoholismoCulpableFormaDeBeber { get; set; }

    public string? AlcoholismoPrimeroEnLaMañana { get; set; }

    public string? VacunaContraHb { get; set; }

    public string? VacunaDobleBacteriana { get; set; }

    public string? VacunaAntigripal { get; set; }

    public string? VacunaOtra { get; set; }

    public string? AlimentacionSaludable { get; set; }

    public string? ActividadFisica { get; set; }

    public string? ObservacionesPp { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
