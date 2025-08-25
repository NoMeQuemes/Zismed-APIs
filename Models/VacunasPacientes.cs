using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VacunasPacientes
{
    public int VacunasId { get; set; }

    public int? VacunaId { get; set; }

    public int PacienteId { get; set; }

    public DateTime? FechaAplica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime Creado { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? Modificado { get; set; }

    public bool Anulado { get; set; }

    public int? CentrosVacunacionId { get; set; }

    public string? Nlote { get; set; }

    public string? Observacion { get; set; }

    public int? InstitucionId { get; set; }

    public int? VacunasIdoriginal { get; set; }

    public int? TurnoId { get; set; }

    public virtual Vacunas? Vacuna { get; set; }
}
