﻿using System;
using System.Collections.Generic;

namespace BreweryInventoryEFClasses.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Phone { get; set; }

    public string? ContactName { get; set; }

    public string? SalesPersonName { get; set; }

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
}
