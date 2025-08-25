using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EncabezadoResultado
{
    public int EncabezadoId { get; set; }

    public int ImagenPedidoId { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public bool? Anulado { get; set; }

    public int? InformeGeneralId { get; set; }

    public virtual ImagenPedido ImagenPedido { get; set; } = null!;
}
