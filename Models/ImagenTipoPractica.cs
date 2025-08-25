using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenTipoPractica
{
    public int ImagenTipoPracticaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InformeSimilar { get; set; }

    public virtual ICollection<ImagenPractica> ImagenPractica { get; set; } = new List<ImagenPractica>();
}
