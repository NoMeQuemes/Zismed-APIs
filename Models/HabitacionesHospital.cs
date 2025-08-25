using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HabitacionesHospital
{
    public int HabitacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public int SectorId { get; set; }

    public int PisoId { get; set; }

    public bool Anulado { get; set; }

    public string? InicioServicio { get; set; }

    public bool? MostrarHoraServicio { get; set; }

    public bool? MostrarMedidasGenerales { get; set; }

    public bool? MostrarIndicacionesRetiradas { get; set; }

    public bool AdmiteCuna { get; set; }

    public int? TipoInternacionId { get; set; }

    public int? SectorIdhc { get; set; }

    public int? HabitacionIdhc { get; set; }

    public int? InstitucionId { get; set; }

    public int? ColorId { get; set; }

    public bool? Informa { get; set; }

    public bool? PedidoUrgente { get; set; }

    public int? SectorIosepId { get; set; }

    public string? ColorSala { get; set; }

    public bool? PermiteReserva { get; set; }

    public bool? EsNeo { get; set; }

    public virtual ICollection<Camas> Camas { get; set; } = new List<Camas>();

    public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; } = new List<GuardiaDerivacionExterna>();

    public virtual ICollection<HabitacionXhabitacionPase> HabitacionXhabitacionPase { get; set; } = new List<HabitacionXhabitacionPase>();

    public virtual ICollection<Internaciones> Internaciones { get; set; } = new List<Internaciones>();

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();

    public virtual PisosHospital Piso { get; set; } = null!;

    public virtual SectoresHospital Sector { get; set; } = null!;

    public virtual ICollection<ShockRoomDerivAlHospital> ShockRoomDerivAlHospital { get; set; } = new List<ShockRoomDerivAlHospital>();
}
