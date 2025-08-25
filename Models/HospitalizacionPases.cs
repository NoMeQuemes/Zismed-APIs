using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HospitalizacionPases
{
    public int IdHospitalizacionPases { get; set; }

    public int IdHospitalizacion { get; set; }

    public int IdPase { get; set; }

    public int IdSector { get; set; }

    public DateOnly Fecha { get; set; }

    public int CantidadDias { get; set; }

    public bool Anulado { get; set; }

    public virtual Hospitalizacion IdHospitalizacionNavigation { get; set; } = null!;
}
