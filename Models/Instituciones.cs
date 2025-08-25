using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Instituciones
{
    public int InstitucionId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Logo { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Cuit { get; set; }

    public string? Abreviatura { get; set; }

    public bool Anulado { get; set; }

    public string? LogoInforme { get; set; }

    public int? IdInstitucionHc { get; set; }

    public string? NombreInforme { get; set; }

    public string? Aplicacion { get; set; }

    public bool? Terminos { get; set; }

    public bool? RequiereControles { get; set; }

    public string? CodigoRefes { get; set; }

    public string? CodigoHospital { get; set; }

    public string? DireccionCompleta { get; set; }

    public string? DatosBanco { get; set; }

    public bool? Hpgd { get; set; }

    public bool? Clinica { get; set; }

    public bool? ValidaLaboratorio { get; set; }

    public bool? Psiquiatrico { get; set; }

    public int? InstitucionIdiosep { get; set; }

    public int? IdTipoConsumirBono { get; set; }

    public int? InstitucionIdmenu { get; set; }

    public int? InstitucionIdlab { get; set; }

    public int? InstitucionIdmed { get; set; }

    public bool? PacienteProtegido { get; set; }

    public bool? AcompananteInternacion { get; set; }

    public bool? FirmaResponsableCargaLab { get; set; }

    public bool? AltaSoloPrestador { get; set; }

    public bool? AtencionTotem { get; set; }

    public bool? AdmisionaHasta10minAntes { get; set; }

    public bool? AutorizaPedidosWeb { get; set; }

    public bool? MuestraAislamiento { get; set; }

    public virtual TipoConsumirBono? IdTipoConsumirBonoNavigation { get; set; }

    public virtual ICollection<MotivosConsultas> MotivosConsultas { get; set; } = new List<MotivosConsultas>();

    public virtual ICollection<NotificacionesCovid> NotificacionesCovid { get; set; } = new List<NotificacionesCovid>();
}
