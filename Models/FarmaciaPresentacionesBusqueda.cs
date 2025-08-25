using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaPresentacionesBusqueda
{
    public int FarmaciaPresentacionesBusquedaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public bool Anulado { get; set; }
}
