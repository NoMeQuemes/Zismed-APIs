using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RevistaSala
{
    public int RevistaSalaId { get; set; }

    public DateTime FechaHora { get; set; }

    public int InternacionId { get; set; }

    public int PrestadorId { get; set; }

    public int TipoRevistaSalaId { get; set; }

    public string? Observaciones { get; set; }

    public bool Anulado { get; set; }

    public virtual Internaciones Internacion { get; set; } = null!;

    public virtual ICollection<RevistaSalaObstetricia> RevistaSalaObstetricia { get; set; } = new List<RevistaSalaObstetricia>();

    public virtual TipoRevistaSala TipoRevistaSala { get; set; } = null!;
}
