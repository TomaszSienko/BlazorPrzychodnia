﻿using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class Pacjent
{
    public int IdPacjenta { get; set; }

    public string Pesel { get; set; } = null!;

    public int IdAdresu { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string NumerTelefonu { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual Adre IdAdresuNavigation { get; set; } = null!;

    public virtual ICollection<Wizyty> Wizyties { get; set; } = new List<Wizyty>();
}
