using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HospitalizacionObstetricaDetalle
{
    public int IdHospitalizacionObstDet { get; set; }

    public int IdHospitalizacionObst { get; set; }

    public decimal? Peso { get; set; }

    public int? CondicionAlNacer { get; set; }

    public int? Terminacion { get; set; }

    public int? Sexo { get; set; }

    public virtual HospitalizacionObstetrica IdHospitalizacionObstNavigation { get; set; } = null!;
}
