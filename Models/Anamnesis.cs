using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Anamnesis
{
    public int AnamnesisId { get; set; }

    public int PacienteId { get; set; }

    public int TurnoId { get; set; }

    public int PrestadorId { get; set; }

    public DateOnly Fecha { get; set; }

    public string? Hora { get; set; }

    public int TipoAnamnesisId { get; set; }

    public DateTime? Ingreso { get; set; }

    public DateTime? Egreso { get; set; }

    public DateTime? Creado { get; set; }

    public bool Anulado { get; set; }

    public int? InternacionId { get; set; }

    public int? InstitucionId { get; set; }

    public int? AnamnesisIdoriginal { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? IdhistoriaClinica { get; set; }

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneral { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<MotivoConsulta> MotivoConsulta { get; set; } = new List<MotivoConsulta>();

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual TipoAnamnesis TipoAnamnesis { get; set; } = null!;
}
