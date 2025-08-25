using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LabRegistroXestado
{
    public int LabRegistroXestadoId { get; set; }

    public int LaboratorioRegistroId { get; set; }

    public int PracticasEstadoId { get; set; }

    public DateTime FechaHora { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual LaboratorioRegistro LaboratorioRegistro { get; set; } = null!;
}
