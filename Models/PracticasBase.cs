using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasBase
{
    public int PracticaBaseId { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? IdTipoPractica { get; set; }

    public int? IdCapitulo { get; set; }

    public decimal? UnidadEspecialista { get; set; }

    public decimal? UnidadAnestesista { get; set; }

    public byte? NumeroAyudantes { get; set; }

    public decimal? UnidadAyudante1 { get; set; }

    public decimal? UnidadAyudante2 { get; set; }

    public decimal? UnidadAyudante3 { get; set; }

    public decimal? UnidadAyudante4 { get; set; }

    public decimal? UnidadInstrumentista { get; set; }

    public decimal? UnidadGastos { get; set; }

    public int? IdUnidadHonorarios { get; set; }

    public int? IdUnidadGastos { get; set; }

    public string? DescripcionPractica { get; set; }

    public bool Activo { get; set; }

    public bool? Anulado { get; set; }

    public virtual ICollection<PracticaTurnos> PracticaTurnos { get; set; } = new List<PracticaTurnos>();
}
