using System;
using System.Collections.Generic;

namespace BlazorMaiTZ.Models
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
