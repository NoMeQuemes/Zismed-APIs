using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GrupoFamiliar
{
    public int GrupoFamiliarId { get; set; }

    public int PacienteId { get; set; }

    public int FamiliarId { get; set; }

    public int TipoParentezcoId { get; set; }

    public bool Anulado { get; set; }

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual TipoParentezco TipoParentezco { get; set; } = null!;
}
