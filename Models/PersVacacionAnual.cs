using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersVacacionAnual
{
    public int PersVacacionAnualId { get; set; }

    public int EmpleadoId { get; set; }

    public int? InstitucionId { get; set; }

    public int Anio { get; set; }

    public int DiasCorrespondientes { get; set; }

    public int DiasTomados { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionesAnula { get; set; }

    public virtual EmpleadosHospital Empleado { get; set; } = null!;

    public virtual ICollection<PersVacacionAnualHistorial> PersVacacionAnualHistorial { get; set; } = new List<PersVacacionAnualHistorial>();
}
