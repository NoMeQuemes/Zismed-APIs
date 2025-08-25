using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomRegistro
{
    public int ShockRoomRegistroId { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaCarga { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaSalida { get; set; }

    public bool? Derivado { get; set; }

    public int? TipoAltaId { get; set; }

    public int? MedicoSalidaId { get; set; }

    public virtual ICollection<DerivacionDetalleGuardia> DerivacionDetalleGuardia { get; set; } = new List<DerivacionDetalleGuardia>();

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual ICollection<ShockRoomAnamnesis> ShockRoomAnamnesis { get; set; } = new List<ShockRoomAnamnesis>();

    public virtual ICollection<ShockRoomDerivAlHospital> ShockRoomDerivAlHospital { get; set; } = new List<ShockRoomDerivAlHospital>();
}
