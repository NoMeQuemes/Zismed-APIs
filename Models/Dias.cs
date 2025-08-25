using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Dias
{
    public int DiaId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<PrestadorDias> PrestadorDias { get; set; } = new List<PrestadorDias>();

    public virtual ICollection<QuirofanoDias> QuirofanoDias { get; set; } = new List<QuirofanoDias>();

    public virtual ICollection<ServiciosDias> ServiciosDias { get; set; } = new List<ServiciosDias>();
}
