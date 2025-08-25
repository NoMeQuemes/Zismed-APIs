using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MovimientosInternaciones
{
    public int MovimientoInternadoId { get; set; }

    public int InternacionId { get; set; }

    public DateOnly Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public int? DesdeCamaId { get; set; }

    public int? HastaCamaId { get; set; }

    public int? DiagnosticoId { get; set; }

    public string? Motivo { get; set; }

    public int? PrestadorId { get; set; }

    public bool Activo { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public int? MovInternadoIdhc { get; set; }

    public int? TipoInternacionId { get; set; }

    public int? IdEstadoMovIosep { get; set; }

    public int? IdInternadoMovIosep { get; set; }

    public bool? Voluntario { get; set; }

    public int? EstadoId { get; set; }

    public bool? EpicrisisSinCargar { get; set; }

    public bool SoloCama { get; set; }

    public virtual Camas? DesdeCama { get; set; }

    public virtual Camas? HastaCama { get; set; }

    public virtual Internaciones Internacion { get; set; } = null!;

    public virtual Prestadores? Prestador { get; set; }
}
