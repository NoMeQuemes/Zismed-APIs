using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AgendaTareaAdjuntos
{
    public int IdAdjunto { get; set; }

    public int IdAgendaTarea { get; set; }

    public string AdjuntoUrl { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? Id { get; set; }

    public virtual AgendaTareas IdAgendaTareaNavigation { get; set; } = null!;

    public virtual AspNetUsers? IdNavigation { get; set; }
}
