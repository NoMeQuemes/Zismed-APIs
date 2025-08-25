﻿using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LabRegistroDetalle
{
    public int LabRegistroDetalleId { get; set; }

    public int LaboratorioRegistroId { get; set; }

    public int? LabGrupoPracticaId { get; set; }

    public int LaboratorioPracticasId { get; set; }

    public string? Resultado { get; set; }

    public int? OrdenImprimir { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCarga { get; set; }

    public int? PrestadorId { get; set; }

    public DateTime? FechaCarga { get; set; }

    public bool? NoSolicitado { get; set; }

    public bool? Imprimir { get; set; }

    public bool? Impreso { get; set; }

    public int? LabGrupoPralPracticaId { get; set; }

    public string? CodigoTubo { get; set; }

    public string? UsuarioCargaCodigoTubo { get; set; }

    public DateTime? FechaCargaCodigoTubo { get; set; }

    public bool? Confirmado { get; set; }

    public virtual ICollection<LabRegistroResultadosLog> LabRegistroResultadosLog { get; set; } = new List<LabRegistroResultadosLog>();
}
