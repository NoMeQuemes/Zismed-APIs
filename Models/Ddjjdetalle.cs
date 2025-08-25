using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Ddjjdetalle
{
    public int DdjjdetalleId { get; set; }

    public int DdjjempleadoId { get; set; }

    public int EmpleadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int IdSexo { get; set; }

    public string Documento { get; set; } = null!;

    public string Cuil { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public int IdEstadoCivil { get; set; }

    public int PaisId { get; set; }

    public int InstitucionId { get; set; }

    public string? FotoRuta { get; set; }

    public bool Anulado { get; set; }

    public string OperCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? OperAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }
}
