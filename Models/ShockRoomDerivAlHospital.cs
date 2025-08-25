using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomDerivAlHospital
{
    public int ShockRoomDerivAlHospitalId { get; set; }

    public int ShockRoomRegistroId { get; set; }

    public int ShockRoomTipoAnamnesisId { get; set; }

    public int HabitacionId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual HabitacionesHospital Habitacion { get; set; } = null!;

    public virtual ShockRoomRegistro ShockRoomRegistro { get; set; } = null!;

    public virtual ShockRoomTipoAnamnesis ShockRoomTipoAnamnesis { get; set; } = null!;
}
