using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CovidInstituciones
{
    public int IdInstitucion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public int IdNacion { get; set; }

    public int RespiradoresAdultos { get; set; }

    public int RespiradoresPediatrico { get; set; }

    public int UtiAdultos { get; set; }

    public int UtiPediatrico { get; set; }

    public bool Dialisis { get; set; }
}
