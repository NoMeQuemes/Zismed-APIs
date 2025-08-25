using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VacunasGrupos
{
    public int GrupoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Orden { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<Vacunas> Vacunas { get; set; } = new List<Vacunas>();
}
