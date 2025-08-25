using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasOrigen
{
    public int PracticasOrigenId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<ImagenRegistro> ImagenRegistro { get; set; } = new List<ImagenRegistro>();

    public virtual ICollection<LaboratorioRegistro> LaboratorioRegistro { get; set; } = new List<LaboratorioRegistro>();
}
