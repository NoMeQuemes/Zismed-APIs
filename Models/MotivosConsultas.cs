using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivosConsultas
{
    public int MotivoConsultaId { get; set; }

    public string? NombreMotivo { get; set; }

    public bool? Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual Instituciones? Institucion { get; set; }
}
