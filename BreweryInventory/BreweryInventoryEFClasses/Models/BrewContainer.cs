﻿using System;
using System.Collections.Generic;

namespace BreweryInventoryEFClasses.Models;

public partial class BrewContainer
{
    public int BrewContainerId { get; set; }

    public string Name { get; set; } = null!;

    public int ContainerStatusId { get; set; }

    public int ContainerTypeId { get; set; }

    public int ContainerSizeId { get; set; }

    public virtual Barrel? Barrel { get; set; }

    public virtual ICollection<BatchContainer> BatchContainers { get; set; } = new List<BatchContainer>();

    public virtual ContainerSize ContainerSize { get; set; } = null!;

    public virtual ContainerStatus ContainerStatus { get; set; } = null!;

    public virtual ContainerType ContainerType { get; set; } = null!;
}
