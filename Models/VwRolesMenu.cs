using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VwRolesMenu
{
    public int IdRolesInMenu { get; set; }

    public int IdMenu { get; set; }

    public string RoleId { get; set; } = null!;

    public string Name { get; set; } = null!;
}
