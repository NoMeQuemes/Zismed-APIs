using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class UsuarioHistoriaClinicaWeb
{
    public int UsuarioHistoriaClinicaId { get; set; }

    public string? Usuario { get; set; }

    public string? Clave { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioId { get; set; }

    public int? PrestadorId { get; set; }
}
