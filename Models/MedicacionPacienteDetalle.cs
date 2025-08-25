using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedicacionPacienteDetalle
{
    public int MedicacionPacienteDetalleId { get; set; }

    public int MedicacionPacienteId { get; set; }

    public int? FarmaciaArticuloId { get; set; }

    public int? NuevaDro { get; set; }

    public int? MultiDro { get; set; }

    public int TipoEstadoMedicacionPacienteDetalleId { get; set; }

    public string ArticuloNombre { get; set; } = null!;

    public string? ArticuloPresentacion { get; set; }

    public string? ArticuloDroga { get; set; }

    public decimal Cantidad { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaRetira { get; set; }

    public DateTime? FechaModifica { get; set; }

    public DateTime? FechaAplicacion { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public string? UsuarioAplica { get; set; }

    public bool Anulado { get; set; }

    public string? Descripcion { get; set; }

    public int? ViaTipoId { get; set; }

    public string? Tipo { get; set; }

    public int? FrecuenciaHs { get; set; }

    public int? Goteo { get; set; }

    public int? TipoGoteoId { get; set; }

    public string? InicioServicio { get; set; }

    public int? ConsultaId { get; set; }

    public string? ObservacionMedico { get; set; }

    public string? ObservacionEnfermero { get; set; }

    public string? ObservacionRevierte { get; set; }

    public int? EnfermeroAplicaId { get; set; }

    public bool? SinStock { get; set; }

    public string? ObservacionSinStock { get; set; }

    public virtual FarmaciaArticulo? FarmaciaArticulo { get; set; }

    public virtual MedicacionPaciente MedicacionPaciente { get; set; } = null!;

    public virtual TipoEstadoMedicacionPacienteDetalle TipoEstadoMedicacionPacienteDetalle { get; set; } = null!;
}
