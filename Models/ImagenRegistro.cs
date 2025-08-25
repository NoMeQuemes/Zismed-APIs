using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenRegistro
{
    public int ImagenRegistroId { get; set; }

    public DateTime FechaPedido { get; set; }

    public bool Urgente { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int PracticasOrigenId { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorSolicita { get; set; }

    public int? PrestadorRealiza { get; set; }

    public bool Anulado { get; set; }

    public int PracticasEstadoId { get; set; }

    public int? SectorId { get; set; }

    public int? GuardiaId { get; set; }

    public int? InterconsultaId { get; set; }

    public string? MotivoAnulado { get; set; }

    public int? InstitucionId { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? DetalleSolicitud { get; set; }

    public virtual ICollection<ImagenPedido> ImagenPedido { get; set; } = new List<ImagenPedido>();

    public virtual ICollection<ImagenRegistroXestado> ImagenRegistroXestado { get; set; } = new List<ImagenRegistroXestado>();

    public virtual Internaciones? Internacion { get; set; }

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual PracticasOrigen PracticasOrigen { get; set; } = null!;

    public virtual Prestadores? PrestadorRealizaNavigation { get; set; }

    public virtual Prestadores PrestadorSolicitaNavigation { get; set; } = null!;

    public virtual Turnos? Turno { get; set; }
}
