using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaDerivacionExterna
{
    public int GuardiaDerivacionExternaId { get; set; }

    public int GuardiaRegistroId { get; set; }

    public int GuardiaSectorId { get; set; }

    public int PrestadorId { get; set; }

    public int? SectorInternadoId { get; set; }

    public int? MovilId { get; set; }

    public int? ServicioId { get; set; }

    public int? CentroId { get; set; }

    public string? Motivo { get; set; }

    public string? OtroMedioTraslado { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public string? OtroCentro { get; set; }

    public string? EstudiosComp { get; set; }

    public string? MedicacionSum { get; set; }

    public string? Antecedentes { get; set; }

    public virtual GuardiaRegistro GuardiaRegistro { get; set; } = null!;

    public virtual GuardiaSector GuardiaSector { get; set; } = null!;

    public virtual MovilHospital? Movil { get; set; }

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual HabitacionesHospital? SectorInternado { get; set; }

    public virtual Servicios? Servicio { get; set; }
}
