using System;
using System.Collections.Generic;

namespace DI_DemowebAPI.Models.EF;

public partial class ProductsInfo
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public int? PPrice { get; set; }

    public bool? PIsInStock { get; set; }
}
