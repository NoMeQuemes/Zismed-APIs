using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedicacionPaciente
{
    public int MedicacionPacienteId { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorPrescribeId { get; set; }

    public int? PrestadorRetiraId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? GuardiaSectorId { get; set; }

    public int? InternacionId { get; set; }

    public int? SectorInternadoId { get; set; }

    public int? TurnoId { get; set; }

    public int? ServicioId { get; set; }

    public int? ConsultaId { get; set; }

    public int MedicacionViaId { get; set; }

    public int? TipoGoteoId { get; set; }

    public int? SolucionId { get; set; }

    public int TipoEstadoMedicacionId { get; set; }

    public int? EmfermeroId { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Programa { get; set; }

    public int? FrecuenciaHs { get; set; }

    public int? Goteo { get; set; }

    public decimal? CantidadSolucion { get; set; }

    public DateTime FechaPrescribe { get; set; }

    public DateTime? FechaRetira { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public DateTime? FechaProcesa { get; set; }

    public DateTime? FechaAplica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public string? UsuarioProcesa { get; set; }

    public string? UsuarioAplica { get; set; }

    public bool Anulado { get; set; }

    public int? PrescripcionId { get; set; }

    public int? EnfermeriaId { get; set; }

    public int? Opcion { get; set; }

    public int? InstitucionId { get; set; }

    public string? Evolucion { get; set; }

    public string? ObservacionAdicional { get; set; }

    public virtual ConsultasAmbulatorias? Consulta { get; set; }

    public virtual ICollection<Enfermeria> Enfermeria { get; set; } = new List<Enfermeria>();

    public virtual GuardiaSector? GuardiaSector { get; set; }

    public virtual Internaciones? Internacion { get; set; }

    public virtual ICollection<MedicacionPacienteDetalle> MedicacionPacienteDetalle { get; set; } = new List<MedicacionPacienteDetalle>();

    public virtual ICollection<MedicacionPacienteHistorico> MedicacionPacienteHistorico { get; set; } = new List<MedicacionPacienteHistorico>();

    public virtual MedicacionVia MedicacionVia { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores PrestadorPrescribe { get; set; } = null!;

    public virtual Prestadores? PrestadorRetira { get; set; }

    public virtual HabitacionesHospital? SectorInternado { get; set; }

    public virtual Servicios? Servicio { get; set; }

    public virtual TipoEstadoMedicacionPaciente TipoEstadoMedicacion { get; set; } = null!;

    public virtual TipoGoteo? TipoGoteo { get; set; }
}
