﻿using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class Kontum
{
    public int IdKonta { get; set; }

    public string? Login { get; set; }

    public string? Haslo { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Email { get; set; }
}
