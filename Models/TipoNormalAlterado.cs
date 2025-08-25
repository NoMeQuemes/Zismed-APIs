using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoNormalAlterado
{
    public int NormalAlteradoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralAparatoCardiovascularNNavigation { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralAparatoRespiratorioNNavigation { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralCabezaCuelloNNavigation { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralMiembroInferiorNNavigation { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralMiembroSuperiorNNavigation { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<RevistaSalaObstetricia> RevistaSalaObstetricia { get; set; } = new List<RevistaSalaObstetricia>();
}
