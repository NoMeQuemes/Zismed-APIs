using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GyO
{
    public int GyOId { get; set; }

    public string Men { get; set; } = null!;

    public string Rm { get; set; } = null!;

    public bool Menopausa { get; set; }

    public bool Amenorrea { get; set; }

    public bool Dismenorrea { get; set; }

    public bool Dispareunia { get; set; }

    public bool Sinusorragia { get; set; }

    public bool Ioe { get; set; }

    public bool Ioa { get; set; }

    public bool Prurito { get; set; }

    public bool Flujo { get; set; }

    public bool Abuela { get; set; }

    public bool Madre { get; set; }

    public bool Tia { get; set; }

    public bool Hermana { get; set; }

    public bool Ovarios { get; set; }

    public bool Mamas { get; set; }

    public bool Utero { get; set; }

    public bool Colon { get; set; }

    public string Detalle { get; set; } = null!;

    public string Dni { get; set; } = null!;
}
