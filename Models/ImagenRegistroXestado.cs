using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenRegistroXestado
{
    public int ImagenRegistroXestadoId { get; set; }

    public int ImagenRegistroId { get; set; }

    public int PracticasEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public virtual ImagenRegistro ImagenRegistro { get; set; } = null!;
}
