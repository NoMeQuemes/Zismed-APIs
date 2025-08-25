using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnalisisLaboratorio
{
    public int AnalisisLaboratorioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PerfilDetalleLaboratorio> PerfilDetalleLaboratorio { get; set; } = new List<PerfilDetalleLaboratorio>();
}
