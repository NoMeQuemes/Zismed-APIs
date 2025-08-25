using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AgendaTareas
{
    public int IdAgendaTarea { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaVence { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Detalle { get; set; }

    public string? Estado { get; set; }

    public bool Anulado { get; set; }

    public string? MotivoAnula { get; set; }

    public string? Color { get; set; }

    public string? Resumen { get; set; }

    public string? Prioridad { get; set; }

    public bool Terminada { get; set; }

    public string? OpAnula { get; set; }

    public string? EmpleadoSolicita { get; set; }

    public string? Categorias { get; set; }

    public int? BienPatrimonial { get; set; }

    public string? NroTarea { get; set; }

    public virtual ICollection<AgendaTareaAdjuntos> AgendaTareaAdjuntos { get; set; } = new List<AgendaTareaAdjuntos>();

    public virtual ICollection<AgendaTareaAspNetUsers> AgendaTareaAspNetUsers { get; set; } = new List<AgendaTareaAspNetUsers>();

    public virtual ICollection<AgendaTareaComentarios> AgendaTareaComentarios { get; set; } = new List<AgendaTareaComentarios>();

    public virtual ICollection<AgendaTareaHistorico> AgendaTareaHistorico { get; set; } = new List<AgendaTareaHistorico>();
}
