using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class Wizyty
{
    public int IdWizyty { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Godzina { get; set; }

    public int IdPacjenta { get; set; }

    public int IdLekarza { get; set; }

    public string? WywiadLekarski { get; set; }

    public string? BadaniePrzedmiotowe { get; set; }

    public string? Zalecenia { get; set; }

    public virtual Lekarz IdLekarzaNavigation { get; set; } = null!;

    public virtual Pacjent IdPacjentaNavigation { get; set; } = null!;

    public virtual ICollection<OpłataZaWizyte> OpłataZaWizytes { get; set; } = new List<OpłataZaWizyte>();

    public virtual ICollection<Receptum> Recepta { get; set; } = new List<Receptum>();

    public virtual ICollection<Skierowanie> Skierowanies { get; set; } = new List<Skierowanie>();

    public virtual ICollection<SzczegółyBadań> SzczegółyBadańs { get; set; } = new List<SzczegółyBadań>();
}
