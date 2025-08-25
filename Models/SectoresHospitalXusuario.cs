using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SectoresHospitalXusuario
{
    public int SectoresHospitalXusuariosId { get; set; }

    public int SectorId { get; set; }

    public string UserId { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }
}
