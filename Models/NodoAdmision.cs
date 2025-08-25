using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoAdmision
{
    public int IdAdmision { get; set; }

    public int IdPaciente { get; set; }

    public int? RegistroContingenteId { get; set; }

    public DateTime? FechaApertura { get; set; }

    public bool? TemperaturaSi { get; set; }

    public bool? TemperaturaNo { get; set; }

    public bool? TemperaturaSd { get; set; }

    public bool? SaturometriaSi { get; set; }

    public bool? SaturometriaNo { get; set; }

    public bool? SaturometriaSd { get; set; }

    public bool? OtroSi { get; set; }

    public bool? OtroNo { get; set; }

    public bool? OtroSd { get; set; }

    public bool RedireccionaNodo { get; set; }

    public int? HospitalId { get; set; }

    public int TipoDeriva { get; set; }

    public string? Observaciones { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionesAnula { get; set; }

    public int? Idinstitucion { get; set; }

    public int? ObraSocialId { get; set; }

    public bool Deriva { get; set; }

    public DateTime? FechaDeriva { get; set; }

    public string? UsuarioDeriva { get; set; }

    public int? IdprestadorAsignado { get; set; }

    public string? UsuarioAsigna { get; set; }

    public DateTime? FechaAsigna { get; set; }

    public string? NroAfiliado { get; set; }

    public int? NodoPacienteEstadoId { get; set; }

    public virtual ICollection<NodoIngreso> NodoIngreso { get; set; } = new List<NodoIngreso>();
}
