using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Mails
{
    public int MailId { get; set; }

    public int PersonaId { get; set; }

    public int TipoMailId { get; set; }

    public string Email { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Personas Persona { get; set; } = null!;

    public virtual TipoMail TipoMail { get; set; } = null!;
}
