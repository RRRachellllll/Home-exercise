using System;
using System.Collections.Generic;

namespace EntityFrameWork;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Count { get; set; }

    public int? BuyId { get; set; }

    public virtual Buy? Buy { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
