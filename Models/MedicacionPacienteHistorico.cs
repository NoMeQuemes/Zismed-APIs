using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedicacionPacienteHistorico
{
    public int MedicacionPacienteHistoricoId { get; set; }

    public int MedicacionPacienteId { get; set; }

    public string Accion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual MedicacionPaciente MedicacionPaciente { get; set; } = null!;
}
