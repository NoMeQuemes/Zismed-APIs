using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotificacionCovidResidencia
{
    public int NotificacionCovidResidenciaId { get; set; }

    public int NotificacionId { get; set; }

    public int PacienteId { get; set; }

    public int? ProvinciaId { get; set; }

    public string? Departamento { get; set; }

    public string? Localidad { get; set; }

    public string? CalleManzana { get; set; }

    public string? NumeroCasa { get; set; }

    public string? Piso { get; set; }

    public string? Depto { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Barrio { get; set; }

    public string? Telefono { get; set; }

    public bool? Anulado { get; set; }

    public virtual NotificacionesCovid Notificacion { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Provincias? Provincia { get; set; }
}
