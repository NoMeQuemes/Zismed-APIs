using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedicacionDiscreta
{
    public int MedicacionDiscretaId { get; set; }

    public int? InternacionId { get; set; }

    public int MedicacionViaId { get; set; }

    public int FrecuenciaHs { get; set; }

    public string Programa { get; set; } = null!;

    public int PacienteId { get; set; }

    public int PrestadorIdindica { get; set; }

    public int? PrestadorIdretira { get; set; }

    public int? FarMedicamentoId { get; set; }

    public int? NuevaDro { get; set; }

    public int? MultiDro { get; set; }

    public int? NroRegistro { get; set; }

    public string MedPresentacion { get; set; } = null!;

    public string MedNombre { get; set; } = null!;

    public DateTime FechaIndica { get; set; }

    public DateTime? FechaRetira { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public virtual FarMedicamento? FarMedicamento { get; set; }

    public virtual ICollection<IndicacionesRegistroAplicacion> IndicacionesRegistroAplicacion { get; set; } = new List<IndicacionesRegistroAplicacion>();

    public virtual MedicacionVia MedicacionVia { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores PrestadorIdindicaNavigation { get; set; } = null!;

    public virtual Prestadores? PrestadorIdretiraNavigation { get; set; }
}
