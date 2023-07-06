using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class BadanieDodatkowe
{
    public int IdBadaniaDodatkowe { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Rodzaj { get; set; } = null!;

    public virtual ICollection<SzczegółyBadań> SzczegółyBadańs { get; set; } = new List<SzczegółyBadań>();
}
