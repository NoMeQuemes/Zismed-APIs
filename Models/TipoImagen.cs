using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoImagen
{
    public int TipoImagenId { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreImagenGuardada { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PacienteFotos> PacienteFotos { get; set; } = new List<PacienteFotos>();
}
