using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenPractica
{
    public int ImagenPracticaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int ImagenTipoPracticaId { get; set; }

    public bool Anulado { get; set; }

    public string? Codigo { get; set; }

    public virtual ICollection<ImagenPedido> ImagenPedido { get; set; } = new List<ImagenPedido>();

    public virtual ImagenTipoPractica ImagenTipoPractica { get; set; } = null!;
}
