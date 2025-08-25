using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Odontograma
{
    public int IdOdontograma { get; set; }

    public int IdPaciente { get; set; }

    public int IdTratamientoOdontologico { get; set; }

    public int Diente { get; set; }

    public string Cara { get; set; } = null!;

    public DateTime FechaTratamiento { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? ConsultaId { get; set; }

    public int? IdOdontogramaOriginal { get; set; }

    public virtual Pacientes IdPacienteNavigation { get; set; } = null!;

    public virtual PrestacionesOdontologicas IdTratamientoOdontologicoNavigation { get; set; } = null!;
}
