using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Bonos
{
    public int BonoId { get; set; }

    public string Numero { get; set; } = null!;

    public DateTime FechaVencimiento { get; set; }

    public int PacienteId { get; set; }

    public int ObraSocialId { get; set; }

    public int? ServicioId { get; set; }

    public int PrestadorId { get; set; }

    public int CantidadTurnos { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int InstitucionId { get; set; }

    public bool Anulado { get; set; }

    public int? TotalTurnos { get; set; }

    public string? UserAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public virtual ObraSocial ObraSocial { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual Servicios? Servicio { get; set; }
}
