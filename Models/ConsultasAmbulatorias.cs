using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ConsultasAmbulatorias
{
    public int ConsultaId { get; set; }

    public int PacienteId { get; set; }

    public int? TurnoId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? GuardiaSectorId { get; set; }

    public int? InterconsultaId { get; set; }

    public int? CamaId { get; set; }

    public int PrestadorId { get; set; }

    public int? ServicioId { get; set; }

    public DateTime Fecha { get; set; }

    public int DiagnosticoPrincipalId { get; set; }

    public int DiagnosticoSecundarioId { get; set; }

    public string? Evolucion { get; set; }

    public int ObraSocialId { get; set; }

    public string? Presuntivo { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? MotivoAnula { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? Prescripcion { get; set; }

    public bool? Visible { get; set; }

    public int? InstitucionId { get; set; }

    public string? Indicacion { get; set; }

    public int? ConsultaIdoriginal { get; set; }

    public bool? Psiquiatrico { get; set; }

    public bool? MigradoJardin { get; set; }

    public int? DiagnosticoSnomed { get; set; }

    public string? Informe { get; set; }

    public string? DiagnosticoPrincipalVar { get; set; }

    public virtual Camas? Cama { get; set; }

    public virtual DiagnosticosConsultas DiagnosticoSecundario { get; set; } = null!;

    public virtual ICollection<Hcsnomed> Hcsnomed { get; set; } = new List<Hcsnomed>();

    public virtual Interconsulta? Interconsulta { get; set; }

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();

    public virtual ObraSocial ObraSocial { get; set; } = null!;

    public virtual ICollection<PedidosEnConsultorio> PedidosEnConsultorio { get; set; } = new List<PedidosEnConsultorio>();
}
