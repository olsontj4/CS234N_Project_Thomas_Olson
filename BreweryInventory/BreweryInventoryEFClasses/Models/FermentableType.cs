﻿using System;
using System.Collections.Generic;

namespace BreweryInventoryEFClasses.Models;

public partial class FermentableType
{
    public int FermentableTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Fermentable> Fermentables { get; set; } = new List<Fermentable>();
}
