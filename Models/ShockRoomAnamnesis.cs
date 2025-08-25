using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomAnamnesis
{
    public int ShockRoomAnamnesisId { get; set; }

    public int PacienteId { get; set; }

    public int? ShockRoomRegistroId { get; set; }

    public int? TurnoId { get; set; }

    public int PrestadorId { get; set; }

    public DateOnly Fecha { get; set; }

    public string? Hora { get; set; }

    public int ShockRoomTipoAnamnesisId { get; set; }

    public DateTime? Ingreso { get; set; }

    public DateTime? Egreso { get; set; }

    public DateTime? Creado { get; set; }

    public bool Anulado { get; set; }

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual ShockRoomRegistro? ShockRoomRegistro { get; set; }

    public virtual ShockRoomTipoAnamnesis ShockRoomTipoAnamnesis { get; set; } = null!;
}
