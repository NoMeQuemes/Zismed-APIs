using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Servicios
{
    public int ServicioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Internado { get; set; }

    public bool Guardia { get; set; }

    public int ConsultorioId { get; set; }

    public int EspecilidadId { get; set; }

    public int PrestadorId { get; set; }

    public int TipoPedidoId { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCarga { get; set; }

    public string? UsuarioMod { get; set; }

    public string? UsuarioBaja { get; set; }

    public DateTime? UltimaMod { get; set; }

    public bool TiempoAtencionAperturaVentana { get; set; }

    public bool? EsImagen { get; set; }

    public bool? SePlanificaSolo { get; set; }

    public bool? Planificable { get; set; }

    public int? InstitucionId { get; set; }

    public int? TipoServicioAmbId { get; set; }

    public bool? MarcaAtendido { get; set; }

    public bool? ServAdmisiona { get; set; }

    public bool? MostrarFiltrado { get; set; }

    public string? ColorFilas { get; set; }

    public int? ServicioIdoriginal { get; set; }

    public bool? PorPrestador { get; set; }

    public bool? PedidoUrgente { get; set; }

    public bool? ConfirmacionAutomatica { get; set; }

    public bool? ServicioTotem { get; set; }

    public int? SexoId { get; set; }

    public int? TipoPacienteId { get; set; }

    public int? DiasMostradosTotem { get; set; }

    public bool? AdmisionarTotem { get; set; }

    public int? TipoPracticaId { get; set; }

    public int? EdadMax { get; set; }

    public int? EdadMin { get; set; }

    public int? ProximoControlMeses { get; set; }

    public bool? Transversal { get; set; }

    public bool? MultiTurno { get; set; }

    public bool TurnoWhatsapp { get; set; }

    public virtual Especialidades Especilidad { get; set; } = null!;

    public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; } = new List<GuardiaDerivacionExterna>();

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();

    public virtual ICollection<PlanillaTurnos> PlanillaTurnos { get; set; } = new List<PlanillaTurnos>();

    public virtual ICollection<PrestadoresServicios> PrestadoresServicios { get; set; } = new List<PrestadoresServicios>();

    public virtual ICollection<ServiciosDias> ServiciosDias { get; set; } = new List<ServiciosDias>();

    public virtual ICollection<TipoAnamnesis> TipoAnamnesis { get; set; } = new List<TipoAnamnesis>();

    public virtual ICollection<Turnos> Turnos { get; set; } = new List<Turnos>();
}
