using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AgendaTareaComentarios
{
    public int IdAgendaComentario { get; set; }

    public int? IdAgendaTarea { get; set; }

    public string? Id { get; set; }

    public string? Comentario { get; set; }

    public bool Anulado { get; set; }

    public DateTime FechaComentario { get; set; }

    public virtual AgendaTareas? IdAgendaTareaNavigation { get; set; }

    public virtual AspNetUsers? IdNavigation { get; set; }
}
