using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadorDias
{
    public int PrestadorDiasId { get; set; }

    public int PrestadorId { get; set; }

    public int ServicioId { get; set; }

    public int ConsultorioId { get; set; }

    public int DiaId { get; set; }

    public string? MDesde { get; set; }

    public string? MHasta { get; set; }

    public string? TDesde { get; set; }

    public string? THasta { get; set; }

    public string? NDesde { get; set; }

    public string? NHasta { get; set; }

    public string? Frecuencia { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCarga { get; set; }

    public string? UsuarioMod { get; set; }

    public string? UsuarioBaja { get; set; }

    public DateTime? UltimaMod { get; set; }

    /// <summary>
    /// 0
    /// </summary>
    public int? CantPacienteM { get; set; }

    public int? CantPacienteT { get; set; }

    public int? CantPacienteN { get; set; }

    public int? PrestadoresInstitucionesId { get; set; }

    public int? PrestadorDiasIdoriginal { get; set; }

    public int? CantPacProt { get; set; }

    public virtual Dias Dia { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;
}
