using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ProcedimientoEnfermeria
{
    public int ProcedimientoEnfermeriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Codigo { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<ProcedimientoEnfermeriaDetalle> ProcedimientoEnfermeriaDetalle { get; set; } = new List<ProcedimientoEnfermeriaDetalle>();
}
