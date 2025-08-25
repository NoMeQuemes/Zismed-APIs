using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEtnia
{
    public int EtniaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneral { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<NotificacionesCovid> NotificacionesCovid { get; set; } = new List<NotificacionesCovid>();
}
