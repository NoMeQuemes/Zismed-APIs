using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CambioContingente
{
    public int CambioContingenteId { get; set; }

    public int PacienteId { get; set; }

    public int AdmisionId { get; set; }

    public int ViejoContingenteId { get; set; }

    public int NuevoContingenteId { get; set; }

    public int MotivoCambioId { get; set; }

    public string? Observaciones { get; set; }

    public string UsuarioMod { get; set; } = null!;

    public DateTime FechaMdo { get; set; }
}
