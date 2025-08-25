using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedicacionInfusionContinua
{
    public int MedicacionInfusionContinuaId { get; set; }

    public int? InternacionId { get; set; }

    public int MedicacionViaId { get; set; }

    public decimal Cantidad { get; set; }

    public int FarMedicamentoId { get; set; }

    public int TipoGoteoId { get; set; }

    public int Goteo { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorIdindica { get; set; }

    public DateTime FechaIndica { get; set; }

    public int? PrestadorIdretira { get; set; }

    public DateTime? FechaRetira { get; set; }

    public string? UsuarioCarga { get; set; }

    public virtual FarMedicamento FarMedicamento { get; set; } = null!;

    public virtual ICollection<IndicacionesRegistroAplicacion> IndicacionesRegistroAplicacion { get; set; } = new List<IndicacionesRegistroAplicacion>();

    public virtual ICollection<MedicacionInfusionContinuaDetalle> MedicacionInfusionContinuaDetalle { get; set; } = new List<MedicacionInfusionContinuaDetalle>();

    public virtual MedicacionVia MedicacionVia { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores PrestadorIdindicaNavigation { get; set; } = null!;

    public virtual Prestadores? PrestadorIdretiraNavigation { get; set; }

    public virtual TipoGoteo TipoGoteo { get; set; } = null!;
}
