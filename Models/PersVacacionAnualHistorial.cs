using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersVacacionAnualHistorial
{
    public int PersVacacionAnualHistorialId { get; set; }

    public int PersVacacionAnualId { get; set; }

    public int? DiasCorrespondientesAnt { get; set; }

    public int? DiasTomadosAnt { get; set; }

    public int? DiasCorrespondientesNuevo { get; set; }

    public int? DiasTomadosNuevo { get; set; }

    public string Accion { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public virtual PersVacacionAnual PersVacacionAnual { get; set; } = null!;
}
