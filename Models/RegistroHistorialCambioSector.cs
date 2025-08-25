using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RegistroHistorialCambioSector
{
    public int RegistroHistCambioSectorId { get; set; }

    public int IdIngresoNodo { get; set; }

    public int? NodoTipoAntId { get; set; }

    public int MotivoId { get; set; }

    public string Observaciones { get; set; } = null!;

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }
}
