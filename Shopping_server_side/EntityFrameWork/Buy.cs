using System;
using System.Collections.Generic;

namespace EntityFrameWork;

public partial class Buy
{
    public int Id { get; set; }

    public int Count { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
