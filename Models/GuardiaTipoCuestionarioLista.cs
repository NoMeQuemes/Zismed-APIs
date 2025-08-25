using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaTipoCuestionarioLista
{
    public int GuardiaTipoCuestionarioListaId { get; set; }

    public int GuardiaTipoCuestionarioPreguntaId { get; set; }

    public string TextoRespuesta { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual GuardiaTipoCuestionarioPregunta GuardiaTipoCuestionarioPregunta { get; set; } = null!;
}
