using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AfiliadosUpa
{
    public int Id { get; set; }

    public string? ClaveBeneficiario { get; set; }

    public string? AfiApellido { get; set; }

    public string? AfiNombre { get; set; }

    public string? AfiTipoDoc { get; set; }

    public string? AfiClaseDoc { get; set; }

    public string? AfiDni { get; set; }

    public string? AfiSexo { get; set; }

    public string? AfiLocalidad { get; set; }

    public DateTime? AfiFechaNac { get; set; }

    public string? MaTipoDocumento { get; set; }

    public string? MaNroDocumento { get; set; }

    public string? MaApellido { get; set; }

    public string? MaNombre { get; set; }

    public string? PaTipoDocumento { get; set; }

    public string? PaNroDocumento { get; set; }

    public string? PaApellido { get; set; }

    public string? PaNombre { get; set; }

    public string? AfiDomCalle { get; set; }

    public string? AfiDomNro { get; set; }

    public string? AfiDomManzana { get; set; }

    public string? AfiDomPiso { get; set; }

    public string? AfiDomDepto { get; set; }

    public string? AfiDomEntreCalle1 { get; set; }

    public string? AfiDomEntreCalle2 { get; set; }

    public string? AfiDomBarrioParaje { get; set; }

    public string? AfiDomMunicipio { get; set; }

    public string? AfiDomDepartamento { get; set; }

    public string? AfiDomLocalidad { get; set; }

    public string? AfiDomProvincia { get; set; }

    public string? AfiDomCp { get; set; }

    public string? AfiTelefono { get; set; }

    public string? LugarAtencionHabitual { get; set; }

    public byte? MotivoBaja { get; set; }

    public string? MensajeBaja { get; set; }

    public byte? MotivoBajaR { get; set; }

    public string? MensajeBajaR { get; set; }

    public int? Pacienteid { get; set; }
}
