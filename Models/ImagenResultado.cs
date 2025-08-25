using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenResultado
{
    public int ImagenResultadoId { get; set; }

    public int ImagenPedidoId { get; set; }

    public int ImagenPracticaId { get; set; }

    public bool Generico { get; set; }

    public string? Conclusion { get; set; }

    public string? SistemaExcrecion { get; set; }

    public string? CavidadAbdominal { get; set; }

    public string? Vejiga { get; set; }

    public string? ViaBiliar { get; set; }

    public string? Prostata { get; set; }

    public string? Postmiccional { get; set; }

    public string? SistemaVentricular { get; set; }

    public string? Parenquima { get; set; }

    public string? EspaciosExtracerebrales { get; set; }

    public string? Vascularizacion { get; set; }

    public string? TechoOseo { get; set; }

    public string? TechoCartilaginosos { get; set; }

    public string? CabezaFemoral { get; set; }

    public string? NucleosOsificacion { get; set; }

    public string? Inestabilidad { get; set; }

    public string? Epidimio { get; set; }

    public string? MiemborIzquierdo { get; set; }

    public string? MiembroDerecho { get; set; }

    public string? Fum { get; set; }

    public string? EdadMensual { get; set; }

    public string? EdadEcografica { get; set; }

    public string? Feto { get; set; }

    public string? Situacion { get; set; }

    public string? Biometria { get; set; }

    public string? EdadGestacional { get; set; }

    public string? LongCefalo { get; set; }

    public string? CantLiquidoAmniotico { get; set; }

    public string? Vitalidad { get; set; }

    public string? Placenta { get; set; }

    public string? Metrias { get; set; }

    public string? ActividadCardiaca { get; set; }

    public string? MovimientoActivos { get; set; }

    public string? MovimientosRespiratorios { get; set; }

    public string? Internos { get; set; }

    public string? Grado { get; set; }

    public string? Ccef { get; set; }

    public string? Peso { get; set; }

    public string? Ilcf { get; set; }

    public string? Iraumb { get; set; }

    public string? Iracmed { get; set; }

    public string? Corazon { get; set; }

    public string? Torax { get; set; }

    public string? SitusAuricular { get; set; }

    public bool? ConcordanciaAv { get; set; }

    public bool? ConcordanciaVa { get; set; }

    public string? AuriculaDerecha { get; set; }

    public string? AuriculaIzquierda { get; set; }

    public string? ValvulaTricuspide { get; set; }

    public string? VentriculoIzquierdo { get; set; }

    public string? VentriculoDerecho { get; set; }

    public string? ArteriaPulmonar { get; set; }

    public string? SeptumIntrauricular { get; set; }

    public string? ValvulaMitral { get; set; }

    public string? ArteriaAorta { get; set; }

    public string? Ductus { get; set; }

    public string? AortaDescendente { get; set; }

    public string? SeptumInterventricular { get; set; }

    public string? Pericardio { get; set; }

    public string? DetallesUtero { get; set; }

    public string? CavidadEndometrial { get; set; }

    public string? CuelloUterino { get; set; }

    public string? Anexo { get; set; }

    public string? Encabezado { get; set; }

    public bool? Anulado { get; set; }

    public virtual ImagenPedido ImagenPedido { get; set; } = null!;

    public virtual ICollection<ImagenResultadoDetalle> ImagenResultadoDetalle { get; set; } = new List<ImagenResultadoDetalle>();
}
