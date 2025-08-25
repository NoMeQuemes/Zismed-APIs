using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LogExcepciones
{
    public int IdExcepcion { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string IpOrigen { get; set; } = null!;

    public string Controlador { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string Parametros { get; set; } = null!;

    public string DetalleExcepcion { get; set; } = null!;

    public bool Anulado { get; set; }
}
