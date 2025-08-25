using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Oftalmologia
{
    public int OftalmologiaId { get; set; }

    public int ConsultaId { get; set; }

    public string? RlejosDerechoEsf { get; set; }

    public string? RlejosDerechoCil { get; set; }

    public string? RlejosDerechoEje { get; set; }

    public string? RlejosIzquierdoEsf { get; set; }

    public string? RlejosIzquierdoCil { get; set; }

    public string? RlejosIzquierdoEje { get; set; }

    public string? RcercaDerechoEsf { get; set; }

    public string? RcercaDerechoCil { get; set; }

    public string? RcercaDerechoEje { get; set; }

    public string? RcercaizquierdoEsf { get; set; }

    public string? RcercaizquierdoCil { get; set; }

    public string? RcercaizquierdoEje { get; set; }

    public string? PresionIntraOcularOder { get; set; }

    public string? PresionIntraOcularOizq { get; set; }

    public string? VisionCromatica { get; set; }

    public string? ObsBiomicroscopia { get; set; }

    public string? RutaImagenBiomicroscopia { get; set; }

    public string? ObsImagenBiomicroscopia { get; set; }

    public string? ObsFondoOjo { get; set; }

    public string? RutaImagenFondoOjo { get; set; }

    public string? ObsImagenFondoOjo { get; set; }

    public string? RutaImagenEstrabismo { get; set; }

    public string? EstrabismoSi { get; set; }

    public string? EstrabismoSc { get; set; }

    public string? EstrabismoSd { get; set; }

    public string? EstrabismoMi { get; set; }

    public string? EstrabismoMci { get; set; }

    public string? EstrabismoMcd { get; set; }

    public string? EstrabismoMd { get; set; }

    public string? EstrabismoIi { get; set; }

    public string? EstrabismoIc { get; set; }

    public string? EstrabismoId { get; set; }

    public string? ObsEstrabismo { get; set; }

    public string? BielchowskyI { get; set; }

    public string? BielchowskyD { get; set; }

    public string? BielchowskyObs { get; set; }

    public string? AgudezaVisualDsc { get; set; }

    public string? AgudezaVisualDcsc { get; set; }

    public string? AgudezaVisualDcc { get; set; }

    public string? AgudezaVisualDce { get; set; }

    public string? AgudezaVisualIsc { get; set; }

    public string? AgudezaVisualIcsc { get; set; }

    public string? AgudezaVisualIcc { get; set; }

    public string? AgudezaVisualIce { get; set; }

    public string? VisionCercana { get; set; }

    public string? TestAmsler { get; set; }

    public string? RefOd { get; set; }

    public string? RefOi { get; set; }

    public string? RefResumen { get; set; }

    public string? CicloplegiaOi { get; set; }

    public string? CicloplegiaOd { get; set; }

    public string? Motivo { get; set; }

    public bool? Anulado { get; set; }

    public virtual ICollection<PlanillaControl> PlanillaControl { get; set; } = new List<PlanillaControl>();
}
