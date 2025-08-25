using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmfermerosXinstituciones
{
    public int EmfermerosXinstitucionesId { get; set; }

    public int EmfermeroId { get; set; }

    public int InstitucionId { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }
}
