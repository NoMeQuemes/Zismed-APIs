using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivoConsulta
{
    public int MotivoConsultaId { get; set; }

    public int AnamnesisId { get; set; }

    public DateTime? Fecha { get; set; }

    public string DetalleMotivo { get; set; } = null!;

    public string HistorialEnfermedadActual { get; set; } = null!;

    public string? Sintomas { get; set; }

    public bool Anulado { get; set; }

    public virtual Anamnesis Anamnesis { get; set; } = null!;
}
