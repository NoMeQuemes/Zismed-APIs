using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaManExtra
{
    /// <summary>
    /// Manual.Dat
    /// </summary>
    public int NroRegistro { get; set; }

    /// <summary>
    /// Tamanos.txt
    /// </summary>
    public byte Tamanos { get; set; }

    /// <summary>
    /// Acciofar.txt
    /// </summary>
    public int Acciofar { get; set; }

    /// <summary>
    /// Monodro.txt
    /// </summary>
    public int Monodro { get; set; }

    /// <summary>
    /// Formas.txt
    /// </summary>
    public int Formas { get; set; }

    public string Potencia { get; set; } = null!;

    /// <summary>
    /// uPotenci.txt
    /// </summary>
    public int UPotenci { get; set; }

    /// <summary>
    /// tipoUnid.txt
    /// </summary>
    public int TipoUnid { get; set; }

    /// <summary>
    /// Vias.txt
    /// </summary>
    public int Vias { get; set; }

    public virtual AlfaBetaAccioFar AcciofarNavigation { get; set; } = null!;

    public virtual AlfaBetaFormas FormasNavigation { get; set; } = null!;

    public virtual AlfaBetaMonoDro MonodroNavigation { get; set; } = null!;

    public virtual AlfaBetaManualDat NroRegistroNavigation { get; set; } = null!;

    public virtual AlfabetaTamanos TamanosNavigation { get; set; } = null!;

    public virtual AlfaBetaTipoUnid TipoUn { get; set; } = null!;

    public virtual AlfaBetaUPotenci UPotenciNavigation { get; set; } = null!;

    public virtual AlfaBetaVias ViasNavigation { get; set; } = null!;
}
