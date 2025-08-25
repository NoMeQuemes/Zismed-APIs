using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoIngreso
{
    public int IdIngresoNodo { get; set; }

    public int IdPaciente { get; set; }

    public int IdAdmision { get; set; }

    public int? Tos { get; set; }

    public int? Odinofagia { get; set; }

    public int? Difresp { get; set; }

    public int? Anosmia { get; set; }

    public int? Disgeusia { get; set; }

    public int? Otros { get; set; }

    public string? RespuestaOtros { get; set; }

    public int? Gruposintomas { get; set; }

    public int? IdProvincia { get; set; }

    public int? IdLocalidad { get; set; }

    public string? OtrosLugar { get; set; }

    public int? HabitacionId { get; set; }

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public bool Deriva { get; set; }

    public int? CentroId { get; set; }

    public int? CamaId { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaRegistraAlta { get; set; }

    public int? TipoAltaId { get; set; }

    public int? PrestadorAltaId { get; set; }

    public string? Motivo { get; set; }

    public string? AdjuntoUrl { get; set; }

    public string? OtroCentro { get; set; }

    public int? IdProcedencia { get; set; }

    public int? NodoTipoId { get; set; }

    public DateTime? FechaRegistraIngreso { get; set; }

    public int? InstitucionId { get; set; }

    public int? TipoTrasladoId { get; set; }

    public virtual NodoAdmision IdAdmisionNavigation { get; set; } = null!;

    public virtual ICollection<NodoControlesDiarios> NodoControlesDiarios { get; set; } = new List<NodoControlesDiarios>();

    public virtual ICollection<NodoExamenFisico> NodoExamenFisico { get; set; } = new List<NodoExamenFisico>();

    public virtual ICollection<NodoHisopado> NodoHisopado { get; set; } = new List<NodoHisopado>();
}
