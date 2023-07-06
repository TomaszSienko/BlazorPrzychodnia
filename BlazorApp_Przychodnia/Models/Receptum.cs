using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class Receptum
{
    public int IdRecepty { get; set; }

    public int IdWizyty { get; set; }

    public decimal? Refundacja { get; set; }

    public virtual Wizyty IdWizytyNavigation { get; set; } = null!;

    public virtual ICollection<SzczegółyRecepty> SzczegółyRecepties { get; set; } = new List<SzczegółyRecepty>();
}
