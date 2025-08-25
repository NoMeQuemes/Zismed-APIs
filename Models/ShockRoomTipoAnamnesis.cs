using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomTipoAnamnesis
{
    public int ShockRoomTipoAnamnesisId { get; set; }

    public string Nombre { get; set; } = null!;

    public int? ShockRoomServicioId { get; set; }

    public int? PrestadorId { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<DerivacionDetalleGuardia> DerivacionDetalleGuardia { get; set; } = new List<DerivacionDetalleGuardia>();

    public virtual ICollection<ShockRoomAnamnesis> ShockRoomAnamnesis { get; set; } = new List<ShockRoomAnamnesis>();

    public virtual ICollection<ShockRoomAnamnesisDetalle> ShockRoomAnamnesisDetalle { get; set; } = new List<ShockRoomAnamnesisDetalle>();

    public virtual ICollection<ShockRoomDerivAlHospital> ShockRoomDerivAlHospital { get; set; } = new List<ShockRoomDerivAlHospital>();

    public virtual ICollection<ShockRoomDerivInt> ShockRoomDerivInt { get; set; } = new List<ShockRoomDerivInt>();

    public virtual ICollection<ShockRoomEventoEncabezado> ShockRoomEventoEncabezado { get; set; } = new List<ShockRoomEventoEncabezado>();

    public virtual ShockRoomServicios? ShockRoomServicio { get; set; }
}
