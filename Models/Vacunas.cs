using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Vacunas
{
    public int VacunaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int EdadId { get; set; }

    public int GrupoId { get; set; }

    public string? Descripción { get; set; }

    public bool Anulado { get; set; }

    public virtual VacunasEdades Edad { get; set; } = null!;

    public virtual VacunasGrupos Grupo { get; set; } = null!;

    public virtual ICollection<VacunasPacientes> VacunasPacientes { get; set; } = new List<VacunasPacientes>();
}
