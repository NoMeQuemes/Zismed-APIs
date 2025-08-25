using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaDeposito
{
    public int FarmaciaDepositoId { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Principal { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<FarmaciaArticuloDeposito> FarmaciaArticuloDeposito { get; set; } = new List<FarmaciaArticuloDeposito>();

    public virtual ICollection<FarmaciaEgreso> FarmaciaEgreso { get; set; } = new List<FarmaciaEgreso>();

    public virtual ICollection<FarmaciaEnvioDeposito> FarmaciaEnvioDepositoFarmaciaDepositoDestino { get; set; } = new List<FarmaciaEnvioDeposito>();

    public virtual ICollection<FarmaciaEnvioDeposito> FarmaciaEnvioDepositoFarmaciaDepositoOrigen { get; set; } = new List<FarmaciaEnvioDeposito>();

    public virtual ICollection<FarmaciaIngreso> FarmaciaIngreso { get; set; } = new List<FarmaciaIngreso>();
}
