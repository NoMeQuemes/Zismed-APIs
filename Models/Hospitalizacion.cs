using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Hospitalizacion
{
    public int IdHospitalizacion { get; set; }

    public int? IdInternado { get; set; }

    public string? Calle { get; set; }

    public string? Barrio { get; set; }

    public int? IdLocalidad { get; set; }

    public int? IdDepto { get; set; }

    public int? IdProvincia { get; set; }

    public int? IdPais { get; set; }

    public int? IdSexo { get; set; }

    public string? IdMetodoAnticon { get; set; }

    public int? IdSistemaSalud { get; set; }

    public int? IdNivelInstruccion { get; set; }

    public int? IdSituacionLaboral { get; set; }

    public string? Ocupacion { get; set; }

    public int? IdProcedencia { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public int? IdSectorIngreso { get; set; }

    public int? CantDias { get; set; }

    public DateOnly? FechaEgreso { get; set; }

    public int? TotalDias { get; set; }

    public int? IdTipoEgreso { get; set; }

    public bool? Procedimiento { get; set; }

    public string? DescProcedimiento { get; set; }

    public string? DiagCie10 { get; set; }

    public string? DiagOtroCie10 { get; set; }

    public string? OtrasCircunstancias { get; set; }

    public int? DiasOtrasCircuns { get; set; }

    public string? MotivoOtrasCircuns { get; set; }

    public string? LugarOtrasCircuns { get; set; }

    public string? DescOtrasCircuns { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? UsuarioModificaAlta { get; set; }

    public DateTime? FechaModificaAlta { get; set; }

    public int? IdPrestadorAlta { get; set; }

    public int? IdTipoDocMama { get; set; }

    public string? DocumentoMama { get; set; }

    public virtual ICollection<HospitalizacionObstetrica> HospitalizacionObstetrica { get; set; } = new List<HospitalizacionObstetrica>();

    public virtual ICollection<HospitalizacionPases> HospitalizacionPases { get; set; } = new List<HospitalizacionPases>();
}
