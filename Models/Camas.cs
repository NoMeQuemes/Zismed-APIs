using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Camas
{
    public int CamaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int HabitacionId { get; set; }

    public bool EnMantenimiento { get; set; }

    public bool Anulado { get; set; }

    public int? CamaIdhc { get; set; }

    public int? InstitucionId { get; set; }

    public bool? TieneOxigeno { get; set; }

    public bool? Habilitada { get; set; }

    public bool? Considerar { get; set; }

    public int? TipoCamaId { get; set; }

    public int? Reservada { get; set; }

    public virtual ICollection<ConsultasAmbulatorias> ConsultasAmbulatorias { get; set; } = new List<ConsultasAmbulatorias>();

    public virtual HabitacionesHospital Habitacion { get; set; } = null!;

    public virtual ICollection<MovimientosInternaciones> MovimientosInternacionesDesdeCama { get; set; } = new List<MovimientosInternaciones>();

    public virtual ICollection<MovimientosInternaciones> MovimientosInternacionesHastaCama { get; set; } = new List<MovimientosInternaciones>();

    public virtual ICollection<NodoMovimientos> NodoMovimientosDesdeCama { get; set; } = new List<NodoMovimientos>();

    public virtual ICollection<NodoMovimientos> NodoMovimientosHastaCama { get; set; } = new List<NodoMovimientos>();
}
