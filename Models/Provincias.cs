using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Provincias
{
    public int IdProvincia { get; set; }

    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Paises IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<Localidades> Localidades { get; set; } = new List<Localidades>();

    public virtual ICollection<NotificacionCovidResidencia> NotificacionCovidResidencia { get; set; } = new List<NotificacionCovidResidencia>();

    public virtual ICollection<Proveedores> Proveedores { get; set; } = new List<Proveedores>();
}
