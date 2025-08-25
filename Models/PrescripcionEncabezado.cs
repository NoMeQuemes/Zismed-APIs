using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrescripcionEncabezado
{
    public int PrescripcionEncabezadoId { get; set; }

    public int PacienteId { get; set; }

    public int InternacionId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Internaciones Internacion { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual ICollection<Prescripcion> Prescripcion { get; set; } = new List<Prescripcion>();
}
