using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AspNetRoles
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Observacion { get; set; }

    public bool Deleteable { get; set; }

    public string? RolIdoriginal { get; set; }

    public bool? EsCoordinador { get; set; }

    public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; } = new List<AspNetUserRoles>();
}
