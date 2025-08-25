using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrientacionObstetricaFormulario
{
    public int FormularioId { get; set; }

    public int PacienteId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool MuertesPrevias { get; set; }

    public bool AntescedentesAbortos { get; set; }

    public bool PesoMenor2500 { get; set; }

    public bool PesoMayor4500 { get; set; }

    public bool IntHiperoPreeclampsia { get; set; }

    public bool Cirugias { get; set; }

    public bool EmbarazoMult { get; set; }

    public bool Menos16Años { get; set; }

    public bool Mayor40Años { get; set; }

    public bool IsoInmunizacionRhn { get; set; }

    public bool HemorragiaVaginal { get; set; }

    public bool MasaPeivica { get; set; }

    public bool PresionArterial90 { get; set; }

    public bool DiabetesMi { get; set; }

    public bool Nefropatia { get; set; }

    public bool Cardiopatia { get; set; }

    public bool ConsumoDrogas { get; set; }

    public bool OtraEnfermedad { get; set; }

    public string? Descripcion { get; set; }

    public bool Elegible { get; set; }

    public bool Anulado { get; set; }
}
