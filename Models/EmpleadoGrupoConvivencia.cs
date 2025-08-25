using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoGrupoConvivencia
{
    public int EmpleadoGrupoConvivenciaId { get; set; }

    public int EmpleadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Dni { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoCelular { get; set; }

    public int? OcupacionId { get; set; }

    public string? Ocupacion { get; set; }

    public int TipoParentezcoId { get; set; }

    public int? ObraSocialId { get; set; }

    public int? TipoDiscapacidadId { get; set; }

    public string? Discapacidad { get; set; }

    public int? EnfermedadCronicaId { get; set; }

    public string? EnfermedadCronica { get; set; }

    public bool Anulado { get; set; }

    public int? DdjjempleadoId { get; set; }

    public string? UsuarioCarga { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public virtual ObraSocial? ObraSocial { get; set; }

    public virtual TipoParentezco TipoParentezco { get; set; } = null!;
}
