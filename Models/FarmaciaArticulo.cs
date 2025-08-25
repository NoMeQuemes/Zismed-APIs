using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaArticulo
{
    public int FarmaciaArticuloId { get; set; }

    public int? NroRegistro { get; set; }

    public string? CodigoArticulo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Presentacion { get; set; }

    public string? CodigoBarras { get; set; }

    public string? Troquel { get; set; }

    public decimal StockMinimo { get; set; }

    public bool BajaAlfabeta { get; set; }

    public DateTime? FechaBajaAlfabeta { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<MedicacionPacienteDetalle> MedicacionPacienteDetalle { get; set; } = new List<MedicacionPacienteDetalle>();
}
