using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class UsuarioConsultas
{
    public int UsuarioConsultaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? Usuario { get; set; }

    public string? Clave { get; set; }

    public int? InstitucionId { get; set; }

    public string? Detalle { get; set; }

    public int? TipoConsultaId { get; set; }
}
