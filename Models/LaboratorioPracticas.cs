using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioPracticas
{
    public int LaboratorioPracticasId { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public int? LabTipoPracticaId { get; set; }

    public bool EsGrupo { get; set; }

    public string? ValorNormal { get; set; }

    public string? UnidadMedida { get; set; }

    public string? TipoValorResultado { get; set; }

    public bool? Observacion { get; set; }

    public bool Anulado { get; set; }

    public bool Ambulatorio { get; set; }

    public decimal? ValorMaximo { get; set; }

    public decimal? ValorMinimo { get; set; }

    public int? LaboratorioAgrupaSumaId { get; set; }

    public bool? InformeMensual { get; set; }

    public bool Realizandose { get; set; }

    public bool MostrarMedAmbulatorio { get; set; }

    public bool MostrarGuardia { get; set; }

    public bool MostrarInternacion { get; set; }

    public bool Habilitada { get; set; }

    public bool Privado { get; set; }

    public int? InstitucionId { get; set; }

    public int? LaboratorioPracticasIdoriginal { get; set; }

    public int? LaboratorioSeccionId { get; set; }

    public int? LaboratorioMetodoId { get; set; }

    public int? SexoId { get; set; }

    public int? LaboratorioFormulaId { get; set; }

    public string? Abreviatura { get; set; }

    public int? Vigencia { get; set; }

    public bool EsRutina { get; set; }

    public int? LabTipoMuestraId { get; set; }

    public string? Liscode { get; set; }

    public string? Liscoderecepcion { get; set; }

    public virtual ICollection<LabGrupoPractica> LabGrupoPracticaLaboratorioPracticas { get; set; } = new List<LabGrupoPractica>();

    public virtual ICollection<LabGrupoPractica> LabGrupoPracticaLaboratorioPracticasIdgrupoNavigation { get; set; } = new List<LabGrupoPractica>();

    public virtual LabTipoMuestra? LabTipoMuestra { get; set; }

    public virtual LabTipoPractica? LabTipoPractica { get; set; }

    public virtual LaboratorioAgrupaSuma? LaboratorioAgrupaSuma { get; set; }

    public virtual ICollection<LaboratorioPracticaListaResultado> LaboratorioPracticaListaResultado { get; set; } = new List<LaboratorioPracticaListaResultado>();

    public virtual ICollection<LaboratorioPracticaMuestra> LaboratorioPracticaMuestra { get; set; } = new List<LaboratorioPracticaMuestra>();
}
