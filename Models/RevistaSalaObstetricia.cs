using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RevistaSalaObstetricia
{
    public int RevistaSalaObstetricia1 { get; set; }

    public int RevistaSalaId { get; set; }

    public bool? AbdomenBando { get; set; }

    public bool? AbdomenConDefensa { get; set; }

    public bool? AbdomenDepresible { get; set; }

    public bool? AbdomenDoloroso { get; set; }

    public bool? AbdeomenReaccionPeritoneal { get; set; }

    public bool? AbdemenToleraAlimentacion { get; set; }

    public bool? AbdomenRha { get; set; }

    public bool? AbdomenCatarsis { get; set; }

    public bool? UteroRetraido { get; set; }

    public bool? UteroInvolucionado { get; set; }

    public bool? LoquiosHematicos { get; set; }

    public bool? LoquiosAbundantes { get; set; }

    public bool? LoquiosFetidos { get; set; }

    public bool? PerineIndemne { get; set; }

    public bool? PerineEpisiorafia { get; set; }

    public bool? PerineCicatrizacion { get; set; }

    public int? MiembroInferior { get; set; }

    public int? Temperatura { get; set; }

    public int? Pulso { get; set; }

    public int? TensionArterialMaxima { get; set; }

    public int? TensionArterialMinima { get; set; }

    public int? TipoMamasId { get; set; }

    public bool? MamasSecretantes { get; set; }

    public bool? MamasLactancia { get; set; }

    public bool Anulado { get; set; }

    public virtual TipoNormalAlterado? MiembroInferiorNavigation { get; set; }

    public virtual RevistaSala RevistaSala { get; set; } = null!;

    public virtual TipoMamas? TipoMamas { get; set; }
}
