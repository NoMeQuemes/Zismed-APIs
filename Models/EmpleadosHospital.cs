using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadosHospital
{
    public int EmpleadoId { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public byte IdSexo { get; set; }

    public string Documento { get; set; } = null!;

    public string Cuil { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public DateOnly? FechaEgreso { get; set; }

    public string Domicilio { get; set; } = null!;

    public int IdEstadoCivil { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoCelular { get; set; }

    public string? Email { get; set; }

    public string? Titulo { get; set; }

    public string? Categoria { get; set; }

    public int? EmpleadoCategoriaId { get; set; }

    public int? SectorId { get; set; }

    public string? NombreConyuge { get; set; }

    public string? TelefonoConyuge { get; set; }

    public int EmpleadoTipoContratoId { get; set; }

    public bool? RetiraDeposito { get; set; }

    public bool? RetiraFarmacia { get; set; }

    public int? TipoEmpleadoId { get; set; }

    public bool Anulado { get; set; }

    public bool JefeSector { get; set; }

    public string? NroLegajo { get; set; }

    public int? IdPais { get; set; }

    public int? CargoId { get; set; }

    public string? Cargo { get; set; }

    public int? FuncionId { get; set; }

    public string? Funcion { get; set; }

    public string? MinisterioPertenece { get; set; }

    public int? TipoInstruccionId { get; set; }

    public string? Barrio { get; set; }

    public string? CodigoPostal { get; set; }

    public int? IdLocalidad { get; set; }

    public string? Departamento { get; set; }

    public bool? Comedor { get; set; }

    public string? NroMatriculaProfesional { get; set; }

    public string? NroControl { get; set; }

    public string? NroAdmision { get; set; }

    public int? TipoAdmisionHospitalId { get; set; }

    public DateOnly? FechaAdmision { get; set; }

    public int? CargaHorariaSemanal { get; set; }

    public int? CargaHsExtrasSemanal { get; set; }

    public string? FotoRuta { get; set; }

    public bool? FichaMedica { get; set; }

    public string? UsuarioCarga { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string? UsuarioBaja { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? PersIdenReloj { get; set; }

    public int? EspecialidadId { get; set; }

    public int? SectorPlanificacionId { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int? IdReloj { get; set; }

    public int? InstitucionId { get; set; }

    public int? TituloId { get; set; }

    public int? ProfesionId { get; set; }

    public int? ProvinciaId { get; set; }

    public int? BarrioId { get; set; }

    public string? NroPuerta { get; set; }

    public string? Piso { get; set; }

    public string? Manzana { get; set; }

    public string? Lote { get; set; }

    public string? Torre { get; set; }

    public string? Detalle { get; set; }

    public int? DdjjempleadoId { get; set; }

    public int? DepartamentoId { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionesAnula { get; set; }

    public virtual ICollection<DepositoIngresoEgreso> DepositoIngresoEgreso { get; set; } = new List<DepositoIngresoEgreso>();

    public virtual ICollection<EmpleadoCapacitacion> EmpleadoCapacitacion { get; set; } = new List<EmpleadoCapacitacion>();

    public virtual ICollection<EmpleadoIntumizacion> EmpleadoIntumizacion { get; set; } = new List<EmpleadoIntumizacion>();

    public virtual ICollection<EmpleadosSectoresPlanificado> EmpleadosSectoresPlanificado { get; set; } = new List<EmpleadosSectoresPlanificado>();

    public virtual Especialidades? Especialidad { get; set; }

    public virtual EstadoCivil IdEstadoCivilNavigation { get; set; } = null!;

    public virtual Localidades? IdLocalidadNavigation { get; set; }

    public virtual Paises? IdPaisNavigation { get; set; }

    public virtual Sexo IdSexoNavigation { get; set; } = null!;

    public virtual ICollection<PersPlanificacion> PersPlanificacion { get; set; } = new List<PersPlanificacion>();

    public virtual ICollection<PersRegistro> PersRegistro { get; set; } = new List<PersRegistro>();

    public virtual ICollection<PersSolicitudPermiso> PersSolicitudPermiso { get; set; } = new List<PersSolicitudPermiso>();

    public virtual ICollection<PersVacacionAnual> PersVacacionAnual { get; set; } = new List<PersVacacionAnual>();

    public virtual SectoresHospital? Sector { get; set; }

    public virtual TipoAdmisionHospital? TipoAdmisionHospital { get; set; }

    public virtual TipoEmpleado? TipoEmpleado { get; set; }

    public virtual TipoInstruccion? TipoInstruccion { get; set; }
}
