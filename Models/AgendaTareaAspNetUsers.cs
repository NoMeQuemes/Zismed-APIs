using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AgendaTareaAspNetUsers
{
    public int IdAgendaTareaUsers { get; set; }

    public int? IdAgendaTarea { get; set; }

    public string? Id { get; set; }

    public bool Anulado { get; set; }

    public bool? Editado { get; set; }

    public bool? Comentario { get; set; }

    public bool? Adjunto { get; set; }

    public virtual AgendaTareas? IdAgendaTareaNavigation { get; set; }

    public virtual AspNetUsers? IdNavigation { get; set; }
}
