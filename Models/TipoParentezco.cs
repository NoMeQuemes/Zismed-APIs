using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoParentezco
{
    public int TipoParentezcoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<EmpleadoGrupoConvivencia> EmpleadoGrupoConvivencia { get; set; } = new List<EmpleadoGrupoConvivencia>();

    public virtual ICollection<GrupoFamiliar> GrupoFamiliar { get; set; } = new List<GrupoFamiliar>();
}
