using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ObraSocial
{
    public int ObraSocialId { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Sigla { get; set; }

    public string? Domicilio { get; set; }

    public string? Localidad { get; set; }

    public string? CodigoPostal { get; set; }

    public int IdLocalidad { get; set; }

    public string? Provincia { get; set; }

    public int IdProvincia { get; set; }

    public string? Telefono { get; set; }

    public string? Observaciones { get; set; }

    public string? Email { get; set; }

    public string? Web { get; set; }

    public bool Anulado { get; set; }

    public string? NombrePuco { get; set; }

    public string? Cuit { get; set; }

    public string? CondIva { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? Rnos { get; set; }

    public int? ObraSocialIdhc { get; set; }

    public string? TituloInforme { get; set; }

    public bool? EsArt { get; set; }

    public virtual ICollection<ConsultasAmbulatorias> ConsultasAmbulatorias { get; set; } = new List<ConsultasAmbulatorias>();

    public virtual ICollection<EmpleadoGrupoConvivencia> EmpleadoGrupoConvivencia { get; set; } = new List<EmpleadoGrupoConvivencia>();

    public virtual ICollection<Internaciones> Internaciones { get; set; } = new List<Internaciones>();
}
