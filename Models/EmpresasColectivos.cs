using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpresasColectivos
{
    public int EmpresaColectivoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Cuit { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public int ProvinciaId { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }
}
