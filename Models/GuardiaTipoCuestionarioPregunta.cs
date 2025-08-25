using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaTipoCuestionarioPregunta
{
    public int GuardiaTipoCuestionarioPreguntaId { get; set; }

    public int GuardiaTipoCuestionarioId { get; set; }

    public int Orden { get; set; }

    public string Pregunta { get; set; } = null!;

    public bool Obligatorio { get; set; }

    public int CuestionarioTipoRespuestaId { get; set; }

    public decimal? ValorMaximo { get; set; }

    public decimal? ValorMinimo { get; set; }

    public bool Anulado { get; set; }

    public virtual GuardiaTipoCuestionario GuardiaTipoCuestionario { get; set; } = null!;

    public virtual ICollection<GuardiaTipoCuestionarioLista> GuardiaTipoCuestionarioLista { get; set; } = new List<GuardiaTipoCuestionarioLista>();

    public virtual ICollection<GuardiaTipoCuestionarioResultado> GuardiaTipoCuestionarioResultado { get; set; } = new List<GuardiaTipoCuestionarioResultado>();
}
