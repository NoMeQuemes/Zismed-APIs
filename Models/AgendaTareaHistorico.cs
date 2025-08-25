using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AgendaTareaHistorico
{
    public int IdAgendaTareaHistorico { get; set; }

    public int IdAgendaTarea { get; set; }

    public string OpMod { get; set; } = null!;

    public DateTime FechaMod { get; set; }

    public string DatosAnteriores { get; set; } = null!;

    public virtual AgendaTareas IdAgendaTareaNavigation { get; set; } = null!;
}
