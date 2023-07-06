using System;
using System.Collections.Generic;

namespace BlazorApp_Przychodnia.Models;

public partial class Adre
{
    public int IdAdresu { get; set; }

    public string Miasto { get; set; } = null!;

    public string Ulica { get; set; } = null!;

    public string KodPocztowy { get; set; } = null!;

    public string? NrMieszkania { get; set; }

    public virtual ICollection<Pacjent> Pacjents { get; set; } = new List<Pacjent>();
}
