using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoExamenFisico
{
    public int IdExamenFisico { get; set; }

    public int IdIngresoNodo { get; set; }

    public bool? AspectoGeneral { get; set; }

    public bool? TemperaturaMenor375 { get; set; }

    public bool? EdadMenor65 { get; set; }

    public bool? PielyFaneras { get; set; }

    public bool? PartesBlandas { get; set; }

    public bool? Pamenor9060 { get; set; }

    public bool? Fa60100 { get; set; }

    public bool? RestoExamenCardio { get; set; }

    public bool? FcmayorIgual30 { get; set; }

    public bool? SatuMayor30 { get; set; }

    public bool? EntradaAire { get; set; }

    public bool? RestoExamenRespi { get; set; }

    public bool? Abdomen { get; set; }

    public bool? OrientacionTiempoEspacio { get; set; }

    public bool? RestoExamenNeuro { get; set; }

    public bool? Otro { get; set; }

    public bool? Imc { get; set; }

    public bool? Deriva { get; set; }

    public int? HallazgosDosEstrellas { get; set; }

    public int? CentroDerivaId { get; set; }

    public int? CentroEstrellaId { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? Observaciones { get; set; }

    public string? Motivo { get; set; }

    public string? OtroCentroEstrella { get; set; }

    public string? OtroCentroDeriva { get; set; }

    public virtual NodoIngreso IdIngresoNodoNavigation { get; set; } = null!;
}
