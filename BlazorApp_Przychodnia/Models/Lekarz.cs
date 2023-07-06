using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class Lekarz
{
    public int IdLekarza { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Specjalizacja { get; set; } = null!;

    public virtual ICollection<Wizyty> Wizyties { get; set; } = new List<Wizyty>();
}
