using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaRegistro
{
    public int GuardiaRegistroId { get; set; }

    public int PacienteId { get; set; }

    public int GuardiaSectorId { get; set; }

    public int? TipoCuracionId { get; set; }

    public int GuardiaTipoIngresoId { get; set; }

    public int? TipoAltaId { get; set; }

    public int PrestadorIngresoId { get; set; }

    public int? PrestadorEgresoId { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public string UsuarioIngreso { get; set; } = null!;

    public string? UsuarioEgreso { get; set; }

    public string? AltaObservacion { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public DateTime? Llamado { get; set; }

    public string? Orden { get; set; }

    public int? TipoIngresoId { get; set; }

    public DateOnly? FechaForza { get; set; }

    public string? UsuarioForza { get; set; }

    public int? SectorAnterior { get; set; }

    public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; } = new List<GuardiaAnamnesis>();

    public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; } = new List<GuardiaDerivacionExterna>();

    public virtual GuardiaSector GuardiaSector { get; set; } = null!;

    public virtual GuardiaTipoIngreso GuardiaTipoIngreso { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores? PrestadorEgreso { get; set; }

    public virtual Prestadores PrestadorIngreso { get; set; } = null!;

    public virtual TipoAltaIntenado? TipoAlta { get; set; }

    public virtual TipoCuracion? TipoCuracion { get; set; }
}
