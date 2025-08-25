using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PerfilDetalleLaboratorio
{
    public int DetalleLaboratorioId { get; set; }

    public int GeneralLaboratorioId { get; set; }

    public int AnalisisLaboratorioId { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<AdmisionLaboratorio> AdmisionLaboratorio { get; set; } = new List<AdmisionLaboratorio>();

    public virtual AnalisisLaboratorio AnalisisLaboratorio { get; set; } = null!;

    public virtual PerfilGeneralLaboratorio GeneralLaboratorio { get; set; } = null!;
}
