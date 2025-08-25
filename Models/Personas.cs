using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Personas
{
    public int PersonaId { get; set; }

    public string NombreVisible { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int TipoDocumentoId { get; set; }

    public string Documento { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public byte IdSexo { get; set; }

    public int? TipoInstruccionId { get; set; }

    public int TipoPersonaId { get; set; }

    public int TipoCuitid { get; set; }

    public string CuitCuil { get; set; } = null!;

    public int? IdEstadoCivil { get; set; }

    public short? SituacionTribId { get; set; }

    public int? SituacionLaboralId { get; set; }

    public string? Web { get; set; }

    public bool? EnviarPublicidad { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    /// <summary>
    /// Código de clasificación...Indica cual es el id del clasificador de gastos.
    /// </summary>
    public DateOnly? FechaEgreso { get; set; }

    public DateTime? FechaAnulado { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<BancosPersonas> BancosPersonas { get; set; } = new List<BancosPersonas>();

    public virtual ICollection<Contactos> Contactos { get; set; } = new List<Contactos>();

    public virtual ICollection<Domicilios> Domicilios { get; set; } = new List<Domicilios>();

    public virtual ICollection<GruposPersonas> GruposPersonas { get; set; } = new List<GruposPersonas>();

    public virtual EstadoCivil? IdEstadoCivilNavigation { get; set; }

    public virtual Sexo IdSexoNavigation { get; set; } = null!;

    public virtual ICollection<Mails> Mails { get; set; } = new List<Mails>();

    public virtual ICollection<Observaciones> Observaciones { get; set; } = new List<Observaciones>();

    public virtual ICollection<PersonasTipoDetalle> PersonasTipoDetalle { get; set; } = new List<PersonasTipoDetalle>();

    public virtual SituacionLaboral? SituacionLaboral { get; set; }

    public virtual SituacionTributaria? SituacionTrib { get; set; }

    public virtual ICollection<Telefonos> Telefonos { get; set; } = new List<Telefonos>();

    public virtual TipoCuit TipoCuit { get; set; } = null!;

    public virtual TipoDocumento TipoDocumento { get; set; } = null!;

    public virtual TipoInstruccion? TipoInstruccion { get; set; }

    public virtual TipoPersona TipoPersona { get; set; } = null!;
}
