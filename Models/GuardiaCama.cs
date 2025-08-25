using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaCama
{
    public int GuardiaCamaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Cama { get; set; }

    public bool Box { get; set; }

    public bool Ocupada { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public int? GuardiaSectorId { get; set; }
}
