using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnestesiaFormulario
{
    public int AnestesiaFormularioId { get; set; }

    public int? PacienteId { get; set; }

    public int? InternacionId { get; set; }

    public int? Servicio { get; set; }

    public decimal? Peso { get; set; }

    public DateTime? InicioAnes { get; set; }

    public DateTime? FinAnes { get; set; }

    public string? Premedicacion { get; set; }

    public string? Hallazgos { get; set; }

    public string? Induccion { get; set; }

    public string? Entubacion { get; set; }

    public string? Operacion { get; set; }

    public string? AnestX { get; set; }

    public string? Observacion { get; set; }

    public string? HoraObservacion { get; set; }

    public string? Fluidos { get; set; }

    public string? Recuperacion { get; set; }

    public string? HemoObservacion { get; set; }

    public decimal? HemoSangre { get; set; }

    public decimal? HemoPlasma { get; set; }

    public decimal? HemoSuero { get; set; }

    public decimal? HemoOtros { get; set; }

    public string? UsuarioCarga { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<AnestesiaMedicacion> AnestesiaMedicacion { get; set; } = new List<AnestesiaMedicacion>();

    public virtual ICollection<AnestesiaMetodo> AnestesiaMetodo { get; set; } = new List<AnestesiaMetodo>();

    public virtual ICollection<AnestesiaPulso> AnestesiaPulso { get; set; } = new List<AnestesiaPulso>();

    public virtual ICollection<AnestesiaRespiracion> AnestesiaRespiracion { get; set; } = new List<AnestesiaRespiracion>();
}
