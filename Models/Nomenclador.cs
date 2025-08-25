using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Nomenclador
{
    public int NomencladorId { get; set; }

    public int? TipoAtencion { get; set; }

    public string? Codigos { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionNva { get; set; }

    public string? Restriccion { get; set; }

    public double? Arancel { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public bool Anulado { get; set; }

    public int? Categoria { get; set; }

    public decimal? Arancel2 { get; set; }

    public decimal? Arancel3 { get; set; }

    public decimal? Arancel4 { get; set; }

    public virtual ICollection<NomExpedienteDetalle> NomExpedienteDetalle { get; set; } = new List<NomExpedienteDetalle>();

    public virtual ICollection<NomencladorResolucion> NomencladorResolucion { get; set; } = new List<NomencladorResolucion>();
}
