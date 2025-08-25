using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenPedidoEstado
{
    public int ImagenPedidoEstadoId { get; set; }

    public int? ImagenPedidoId { get; set; }

    public string? UsuarioMarcaRealizado { get; set; }

    public DateTime? FechaMarcaRealizado { get; set; }

    public bool? Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? TecnicoId { get; set; }
}
