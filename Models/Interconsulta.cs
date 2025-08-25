using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Interconsulta
{
    public int InterconsultaId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? GuardiaSectorId { get; set; }

    public int PrestadorId { get; set; }

    public DateOnly? FechaInterconsulta { get; set; }

    public DateTime FechaPedido { get; set; }

    public DateTime? FechaRealiza { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? NoAtendido { get; set; }

    public string? MotivoNoAtiende { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? InstitucionId { get; set; }

    public int? ServicioId { get; set; }

    public string? DetalleSolicitud { get; set; }

    public int? TurnoId { get; set; }

    public virtual ICollection<ConsultasAmbulatorias> ConsultasAmbulatorias { get; set; } = new List<ConsultasAmbulatorias>();

    public virtual Internaciones? Internacion { get; set; }

    public virtual Prestadores Prestador { get; set; } = null!;
}
