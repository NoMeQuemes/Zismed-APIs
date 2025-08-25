using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class IndicacionesRegistroAplicacion
{
    public int IndicacionesRegistroAplicacionId { get; set; }

    public DateTime FechaAplica { get; set; }

    public int? MedicacionInfusionContinuaId { get; set; }

    public int? MedicacionDiscretaId { get; set; }

    public int? IndicacionesVentilacionMecanicaId { get; set; }

    public int? IndicacionesPosicionId { get; set; }

    public int? IndicacionesKinesiologiaId { get; set; }

    public int? IndicacionesDietaId { get; set; }

    public string Usuario { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual IndicacionesDieta? IndicacionesDieta { get; set; }

    public virtual IndicacionesKinesiologia? IndicacionesKinesiologia { get; set; }

    public virtual IndicacionesPosicion? IndicacionesPosicion { get; set; }

    public virtual ICollection<IndicacionesRegistroAplicacionDescartables> IndicacionesRegistroAplicacionDescartables { get; set; } = new List<IndicacionesRegistroAplicacionDescartables>();

    public virtual IndicacionesVentilacionMecanica? IndicacionesVentilacionMecanica { get; set; }

    public virtual MedicacionDiscreta? MedicacionDiscreta { get; set; }

    public virtual MedicacionInfusionContinua? MedicacionInfusionContinua { get; set; }
}
