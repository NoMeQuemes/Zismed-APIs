using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenesXservicio
{
    public int ImagenPracticaId { get; set; }

    public int ServicioId { get; set; }

    public bool? Anulado { get; set; }
}
