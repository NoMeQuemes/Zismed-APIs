using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SectoresHospital
{
    public int SectorId { get; set; }

    public string Nombre { get; set; } = null!;

    public int CupoPermisosDiario { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<BienPatrimonialMovimientos> BienPatrimonialMovimientos { get; set; } = new List<BienPatrimonialMovimientos>();

    public virtual ICollection<BienesPatrimoniales> BienesPatrimoniales { get; set; } = new List<BienesPatrimoniales>();

    public virtual ICollection<DepositoEncabezado> DepositoEncabezado { get; set; } = new List<DepositoEncabezado>();

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();

    public virtual ICollection<HabitacionesHospital> HabitacionesHospital { get; set; } = new List<HabitacionesHospital>();

    public virtual ICollection<PedidoInternoEncabezado> PedidoInternoEncabezadoDestinoSector { get; set; } = new List<PedidoInternoEncabezado>();

    public virtual ICollection<PedidoInternoEncabezado> PedidoInternoEncabezadoSolicitaSector { get; set; } = new List<PedidoInternoEncabezado>();

    public virtual ICollection<PersSolicitudPermiso> PersSolicitudPermiso { get; set; } = new List<PersSolicitudPermiso>();
}
