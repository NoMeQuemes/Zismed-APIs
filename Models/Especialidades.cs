using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Especialidades
{
    public int EspecialidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Grilla { get; set; }

    public bool Anulado { get; set; }

    public int? EspecialidadIdhc { get; set; }

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();

    public virtual ICollection<Prestadores> Prestadores { get; set; } = new List<Prestadores>();

    public virtual ICollection<PrestadoresEspecialidades> PrestadoresEspecialidades { get; set; } = new List<PrestadoresEspecialidades>();

    public virtual ICollection<Servicios> Servicios { get; set; } = new List<Servicios>();
}
