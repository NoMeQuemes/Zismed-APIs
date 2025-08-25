using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HabitacionXhabitacionPase
{
    public int IdHabitacionXhabitacionPase { get; set; }

    public int IdHabitacionDeriva { get; set; }

    public int IdHabitacioPase { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? FechaCrea { get; set; }

    public virtual HabitacionesHospital IdHabitacionDerivaNavigation { get; set; } = null!;
}
