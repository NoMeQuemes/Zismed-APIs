using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PlanillaTurnos
{
    public int PlanillaTurnoId { get; set; }

    public DateOnly Fecha { get; set; }

    public short Turno { get; set; }

    public int ServicioId { get; set; }

    public int PrestadorId { get; set; }

    public int ConsultorioId { get; set; }

    public string? Opcrea { get; set; }

    public string? Opmodifica { get; set; }

    public bool Anulado { get; set; }

    public int? PlanillaTurnoIdoriginal { get; set; }

    public virtual Consultorios Consultorio { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual Servicios Servicio { get; set; } = null!;
}
