using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivoProtegido
{
    public int IdMotivoProtegido { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Tipo { get; set; }

    public DateTime FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public int? IdInstitucion { get; set; }

    public bool ControlPorServicio { get; set; }

    public bool ControlPorPrestador { get; set; }

    public virtual ICollection<MotivoProtegidoPaciente> MotivoProtegidoPaciente { get; set; } = new List<MotivoProtegidoPaciente>();

    public virtual ICollection<MotivoProtegidoRol> MotivoProtegidoRol { get; set; } = new List<MotivoProtegidoRol>();
}
