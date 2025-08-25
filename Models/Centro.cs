using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Centro
{
    public int CentroId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public string Telefonos { get; set; } = null!;

    public string? Email { get; set; }

    public string? Web { get; set; }

    public bool Anulado { get; set; }
}
