using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarTipoEgreso
{
    public int FarTipoEgresoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Codigo { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string CreaUsuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<FarmaciaEgreso> FarmaciaEgreso { get; set; } = new List<FarmaciaEgreso>();
}
