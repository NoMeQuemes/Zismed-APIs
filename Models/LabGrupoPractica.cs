using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LabGrupoPractica
{
    public int LabGrupoPracticaId { get; set; }

    public int LaboratorioPracticasIdgrupo { get; set; }

    public int LaboratorioPracticasId { get; set; }

    public int? OrdenGrupo { get; set; }

    public bool Anulado { get; set; }

    public int? SexoId { get; set; }

    public int? LaboratorioMetodoId { get; set; }

    public int? LaboratorioSeccionId { get; set; }

    public virtual LaboratorioPracticas LaboratorioPracticas { get; set; } = null!;

    public virtual LaboratorioPracticas LaboratorioPracticasIdgrupoNavigation { get; set; } = null!;
}
