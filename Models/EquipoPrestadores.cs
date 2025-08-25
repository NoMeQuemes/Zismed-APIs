using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EquipoPrestadores
{
    public int EquipoPrestadoresId { get; set; }

    public int? TituloId { get; set; }

    public string? Matricula { get; set; }

    public string Nombre { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Anulado { get; set; }

    public string Cuil { get; set; } = null!;

    public int LocalidadId { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionesAnula { get; set; }

    public string? Apellido { get; set; }

    public string? Celular { get; set; }

    public string? Domicilio { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? Documento { get; set; }

    public DateTime? FechaCreaUsuario { get; set; }
}
