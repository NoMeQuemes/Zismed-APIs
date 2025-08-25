using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenPedido
{
    public int ImagenPedidoId { get; set; }

    public int ImagenPracticaId { get; set; }

    public bool Anulado { get; set; }

    public int ImagenRegistroId { get; set; }

    public string? OpCarga { get; set; }

    public DateTime? FechaCarga { get; set; }

    public int? PracticasEstadoId { get; set; }

    public string? OpAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? ConsultaId { get; set; }

    public DateTime? FechaMarcaRealiza { get; set; }

    public string? UsuarioMarcaRealiza { get; set; }

    public bool? InformeObligatorio { get; set; }

    public int? Cantidad { get; set; }

    public string? UrlPedido { get; set; }

    public bool? EsPentalogic { get; set; }

    public virtual ImagenPractica ImagenPractica { get; set; } = null!;

    public virtual ImagenRegistro ImagenRegistro { get; set; } = null!;

    public virtual ICollection<ImagenResultado> ImagenResultado { get; set; } = new List<ImagenResultado>();
}
