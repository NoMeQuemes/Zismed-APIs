using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DerivacionesEnvios
{
    public int DerivacionesEnviosId { get; set; }

    public int OtrosCentrosId { get; set; }

    public int PacienteId { get; set; }

    public DateOnly Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string MotivoTraslado { get; set; } = null!;

    public int PrestadorId { get; set; }

    public int AnamnesisId { get; set; }

    public DateOnly? FechaRecepcion { get; set; }

    public string? HoraRecepcion { get; set; }

    public bool Anulado { get; set; }

    public string? Usuario { get; set; }

    public bool? Guardia { get; set; }

    public int? MovilHospitalId { get; set; }

    public string? OtroMedioTraslado { get; set; }

    public virtual ICollection<DerivacionDetalleGuardia> DerivacionDetalleGuardia { get; set; } = new List<DerivacionDetalleGuardia>();

    public virtual OtrosCentros OtrosCentros { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;
}
