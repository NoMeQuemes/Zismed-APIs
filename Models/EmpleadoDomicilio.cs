using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoDomicilio
{
    public int EmpleadoDomicilioId { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Calle { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoCelular { get; set; }

    public string? Email { get; set; }

    public string? NroPuerta { get; set; }

    public string? Piso { get; set; }

    public string? Departamento { get; set; }

    public string? Torre { get; set; }

    public string? Manzana { get; set; }

    public string? Barrio { get; set; }

    public int? BarrioId { get; set; }

    public string? Lote { get; set; }

    public string? Detalle { get; set; }

    public string? CodigoPostal { get; set; }

    public int? ProvinciaId { get; set; }

    public int? LocalidadId { get; set; }

    public int? DepartamentoId { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public int? DdjjempleadoId { get; set; }
}
