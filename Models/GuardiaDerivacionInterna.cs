using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaDerivacionInterna
{
    public int GuardiaDerivacionInternaId { get; set; }

    public int GuardiaRegistroId { get; set; }

    public int? GuardiaSectorDesdeId { get; set; }

    public int? ConsultorioDesdeId { get; set; }

    public int? GuardiaSectorHastaId { get; set; }

    public int? GuardiaCamaId { get; set; }

    public int PrestadorId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual Prestadores Prestador { get; set; } = null!;
}
