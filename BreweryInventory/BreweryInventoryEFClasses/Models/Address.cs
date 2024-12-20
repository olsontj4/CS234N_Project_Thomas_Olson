﻿using System;
using System.Collections.Generic;

namespace BreweryInventoryEFClasses.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string StreetLine1 { get; set; } = null!;

    public string? StreetLine2 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? Zipcode { get; set; }

    public string Country { get; set; } = null!;

    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = new List<SupplierAddress>();
}
