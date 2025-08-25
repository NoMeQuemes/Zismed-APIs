using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TurnosQuirofano
{
    public int TurnosQuirofanoId { get; set; }

    public int? TurnoId { get; set; }

    public int? PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public DateTime Fecha { get; set; }

    public int TipoCirugiaId { get; set; }

    public string? DetOperacion { get; set; }

    public int? DiagnosticoId { get; set; }

    public int? CirujanoId { get; set; }

    public string? MotivoReprogramado { get; set; }

    public bool Anulado { get; set; }

    public string? Diagnostico { get; set; }

    public int? QuirofanoId { get; set; }

    public int? PracticasEstadoId { get; set; }

    public int? CirugiaIosepId { get; set; }

    public int? InstitucionId { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public int? InternacionId { get; set; }

    public string? MotivoAnulacion { get; set; }

    public virtual Pacientes? Paciente { get; set; }

    public virtual PracticasEstado? PracticasEstado { get; set; }

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual TipoCirugia TipoCirugia { get; set; } = null!;

    public virtual Turnos? Turno { get; set; }
}
