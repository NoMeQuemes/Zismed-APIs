using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SliderHome
{
    public int SliderId { get; set; }

    public string SliderImgName { get; set; } = null!;

    public string? SliderImgAlt { get; set; }

    public string? SliderImgUrl { get; set; }

    public string? SliderTitle { get; set; }

    public string? SliderParagraph { get; set; }

    public bool SliderEstado { get; set; }

    public int? InstitucionId { get; set; }
}
