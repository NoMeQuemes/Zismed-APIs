using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Domicilios
{
    public int DomicilioId { get; set; }

    public int PersonaId { get; set; }

    public int TipoDomicilioId { get; set; }

    public int BarrioId { get; set; }

    public string Domicilio { get; set; } = null!;

    public string? NroPuerta { get; set; }

    public string? Piso { get; set; }

    public string? Departamento { get; set; }

    public string? Torre { get; set; }

    public string? Km { get; set; }

    public string? Detalle { get; set; }

    public bool Anulado { get; set; }

    public virtual Personas Persona { get; set; } = null!;

    public virtual TipoDomicilio TipoDomicilio { get; set; } = null!;
}
