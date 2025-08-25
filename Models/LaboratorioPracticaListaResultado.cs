using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioPracticaListaResultado
{
    public int LaboratorioPracticaListaResultadoId { get; set; }

    public int LaboratorioPracticasId { get; set; }

    public string TextoRespuesta { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual LaboratorioPracticas LaboratorioPracticas { get; set; } = null!;
}
