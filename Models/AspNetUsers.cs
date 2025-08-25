using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AspNetUsers
{
    public string Id { get; set; } = null!;

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public string? Name { get; set; }

    public string? UserIdoriginal { get; set; }

    public string? Token { get; set; }

    public bool? RequiereCambioClave { get; set; }

    public string? TokenZismed { get; set; }

    public DateTime? CaduceTokenZismed { get; set; }

    public string? UserNameAbbott { get; set; }

    public virtual ICollection<AgendaTareaAdjuntos> AgendaTareaAdjuntos { get; set; } = new List<AgendaTareaAdjuntos>();

    public virtual ICollection<AgendaTareaAspNetUsers> AgendaTareaAspNetUsers { get; set; } = new List<AgendaTareaAspNetUsers>();

    public virtual ICollection<AgendaTareaComentarios> AgendaTareaComentarios { get; set; } = new List<AgendaTareaComentarios>();

    public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; } = new List<AspNetUserClaims>();

    public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; } = new List<AspNetUserLogins>();

    public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; } = new List<AspNetUserRoles>();

    public virtual ICollection<FarmaciaSucursalXusuario> FarmaciaSucursalXusuario { get; set; } = new List<FarmaciaSucursalXusuario>();
}
