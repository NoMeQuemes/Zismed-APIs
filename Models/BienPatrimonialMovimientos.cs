using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class BienPatrimonialMovimientos
{
    public int MovimientoId { get; set; }

    public int BienPatrimonialId { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public string? MotivoSolicitud { get; set; }

    public int SectorId { get; set; }

    public string Solicitante { get; set; } = null!;

    public int EstadoSolicitud { get; set; }

    public string? UsuarioAutoriza { get; set; }

    public DateTime? FechaAutoriza { get; set; }

    public string? Observacion { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? CuilAutoriza { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public int InstitucionId { get; set; }

    public virtual BienesPatrimoniales BienPatrimonial { get; set; } = null!;

    public virtual SectoresHospital Sector { get; set; } = null!;
}
