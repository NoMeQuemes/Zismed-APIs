using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoDatoLaboral
{
    public int EmpleadoDatoLaboralId { get; set; }

    public int EmpleadoId { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public DateOnly? FechaEgreso { get; set; }

    public int? MotivoEgresoId { get; set; }

    public int CategoriaId { get; set; }

    public decimal? Basico { get; set; }

    public decimal? Monto { get; set; }

    public int SectorId { get; set; }

    public int EmpleadoTipoContratoId { get; set; }

    public int? TipoEmpleadoId { get; set; }

    public bool JefeSector { get; set; }

    public bool FichaMedica { get; set; }

    public int CargoId { get; set; }

    public int FuncionId { get; set; }

    public int MinisterioId { get; set; }

    public int IdInstitucion { get; set; }

    public string NroLegajo { get; set; } = null!;

    public string? NroControl { get; set; }

    public string? NroAdmision { get; set; }

    public int TipoAdmisionId { get; set; }

    public DateOnly? FechaAdmision { get; set; }

    public int CargaHorariaSemanal { get; set; }

    public int? CargaHsExtrasSemanal { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionAnula { get; set; }

    public int? DdjjempleadoId { get; set; }
}
