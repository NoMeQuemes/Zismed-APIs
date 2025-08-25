using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioRegistro
{
    public int LaboratorioRegistroId { get; set; }

    public int PacienteId { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int PracticasOrigenId { get; set; }

    public int PracticasEstadoId { get; set; }

    public bool Urgente { get; set; }

    public int NumeroIdentificador { get; set; }

    public int? PrestadorSolicita { get; set; }

    public int? PrestadorRealiza { get; set; }

    public DateTime Fecha { get; set; }

    public bool Anulado { get; set; }

    public string? MotivoModificado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public int? HabitacionId { get; set; }

    public int? GuardiaSectorId { get; set; }

    public int? TurnoReferenciaId { get; set; }

    public int? InstitucionId { get; set; }

    public int? ServicioId { get; set; }

    public bool? Emergente { get; set; }

    public bool? Validado { get; set; }

    public string? CodigoWeb { get; set; }

    public int? PrestadorValida { get; set; }

    public string? CodigoBarra { get; set; }

    public virtual ICollection<LabRegistroXestado> LabRegistroXestado { get; set; } = new List<LabRegistroXestado>();

    public virtual PracticasOrigen PracticasOrigen { get; set; } = null!;

    public virtual Prestadores? PrestadorRealizaNavigation { get; set; }

    public virtual Prestadores? PrestadorSolicitaNavigation { get; set; }

    public virtual Turnos? Turno { get; set; }
}
