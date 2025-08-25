using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zismed_Apis.Models;

public partial class GuardiaSector
{
    public int GuardiaSectorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool ConsultaMedica { get; set; }

    public bool MedicacionContinua { get; set; }

    public bool MedicacionDiscreta { get; set; }

    public bool SignosVitales { get; set; }

    public bool RegistraIngreso { get; set; }

    public bool VeGrillaAtencion { get; set; }

    public bool ProcedimientoCuraciones { get; set; }

    public bool Interconsulta { get; set; }

    public bool Laboratorio { get; set; }

    public bool Observaciones { get; set; }

    public bool Anulado { get; set; }

    public bool? SalidaDirecta { get; set; }

    public bool? AdmisionGral { get; set; }

    public int? InstitucionId { get; set; }

    public int? TvMonitorId { get; set; }

    public bool? TieneCamas { get; set; }

    public int? GuardiaSectorIdoriginal { get; set; }

    public int? ConsultorioId { get; set; }

    public bool? RequiereTelefono { get; set; }

    public bool? BuscarTurnos { get; set; }

    public bool? CompletarDatos { get; set; }

    public bool? Imagenes { get; set; }

    public bool? Balance { get; set; }

    public bool? PedidoUrgente { get; set; }

    public bool? Anamnesis { get; set; }

    public bool? Consentimientos { get; set; }

    public bool? NotificacionesCovid { get; set; }

    public bool? InformeCci { get; set; }

    public int? EdadMin { get; set; }

    public int? EdadMax { get; set; }

    public byte? SexoId { get; set; }

    public bool? EsNeo { get; set; }

    public bool? Embarazada { get; set; }

    public bool? NotificacionDengues { get; set; }

    public bool? Odontograma { get; set; }

    public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; } = new List<GuardiaDerivacionExterna>();
    [JsonIgnore]

    public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; } = new List<GuardiaRegistro>();

    public virtual ICollection<GuardiaSectoresDestino> GuardiaSectoresDestinoGuardiaSectorIddestinoNavigation { get; set; } = new List<GuardiaSectoresDestino>();

    public virtual ICollection<GuardiaSectoresDestino> GuardiaSectoresDestinoGuardiaSectorIdorigenNavigation { get; set; } = new List<GuardiaSectoresDestino>();

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();
}
