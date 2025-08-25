using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Solicitudes
{
    public int IdSolicitud { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? Sector { get; set; }

    public string? Descripcion { get; set; }

    public string? Usuario { get; set; }

    public string? Password { get; set; }

    public string? Tipo { get; set; }

    public string? Documento { get; set; }

    public bool? Aprobada { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? Matricula { get; set; }

    public string? Motivo { get; set; }

    public bool? Rechazada { get; set; }

    public string? OpSolicita { get; set; }

    public string? DetalleRechazo { get; set; }
}
