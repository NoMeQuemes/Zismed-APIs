using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaArticuloDepositoLoteVto
{
    public int FarmaciaArticuloDepositoLoteVtoId { get; set; }

    public int FarmaciaArticuloDepositoId { get; set; }

    public int FarmaciaArticuloId { get; set; }

    public string? Lote { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public decimal Stock { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public int? FarmaciaArticuloAnteriorId { get; set; }

    public virtual ArticulosFarmaciaCis FarmaciaArticulo { get; set; } = null!;

    public virtual FarmaciaArticuloDeposito FarmaciaArticuloDeposito { get; set; } = null!;
}
