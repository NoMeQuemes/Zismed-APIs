using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Categorias
{
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<Productos> Producto { get; set; } = new List<Productos>();
}
