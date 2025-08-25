using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Emfermeros
{
    public int EmfermeroId { get; set; }

    public string? Nombre { get; set; }

    public string? Documento { get; set; }

    public int? InstitucionId { get; set; }

    public bool Anulado { get; set; }

    public string? Usuario { get; set; }

    public int? UsuarioId { get; set; }

    public int? EnfermeroIdhc { get; set; }

    public int? EmfermeroIdoriginal { get; set; }

    public string? Matricula { get; set; }
}
