using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioXusuario
{
    public int LaboratorioXusuarioId { get; set; }

    public int LaboratorioId { get; set; }

    public string UserId { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }
}
