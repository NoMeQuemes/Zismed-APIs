using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ArticulosFarmaciaCis
{
    public int ArticuloFarmaciaCisId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoArticulo { get; set; }

    public bool? Medicamento { get; set; }

    public decimal? StockMinimo { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? UsuarioMod { get; set; }

    public bool? Anulado { get; set; }

    public bool? MedRecienNacido { get; set; }

    public int? InstitucionId { get; set; }

    public int? ArticuloIdhc { get; set; }

    public bool? Solucion { get; set; }

    public int? Presentacion { get; set; }

    public bool? DesdeInternaciones { get; set; }

    public virtual ICollection<AnestesiaMedicacion> AnestesiaMedicacion { get; set; } = new List<AnestesiaMedicacion>();

    public virtual ICollection<FarmaciaArticuloDeposito> FarmaciaArticuloDeposito { get; set; } = new List<FarmaciaArticuloDeposito>();

    public virtual ICollection<FarmaciaArticuloDepositoLoteVto> FarmaciaArticuloDepositoLoteVto { get; set; } = new List<FarmaciaArticuloDepositoLoteVto>();

    public virtual ICollection<FarmaciaEgresoDetalle> FarmaciaEgresoDetalle { get; set; } = new List<FarmaciaEgresoDetalle>();

    public virtual ICollection<FarmaciaEnvioDepositoDetalle> FarmaciaEnvioDepositoDetalle { get; set; } = new List<FarmaciaEnvioDepositoDetalle>();

    public virtual ICollection<FarmaciaEnvioDepositoDetalleLoteVto> FarmaciaEnvioDepositoDetalleLoteVto { get; set; } = new List<FarmaciaEnvioDepositoDetalleLoteVto>();

    public virtual ICollection<FarmaciaIngresoDetalle> FarmaciaIngresoDetalle { get; set; } = new List<FarmaciaIngresoDetalle>();

    public virtual ICollection<ProcedimientoEnfermeriaDetalle> ProcedimientoEnfermeriaDetalle { get; set; } = new List<ProcedimientoEnfermeriaDetalle>();
}
