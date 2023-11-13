using System;
using System.Collections.Generic;

namespace EntityFrameWork;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Count { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
