using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CovidUsuario
{
    public int IdCovidUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Palabra { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public int IdNacion { get; set; }

    public int IdInstitucion { get; set; }

    public bool? Principal { get; set; }

    public int? InstitucionIdoriginal { get; set; }
}
