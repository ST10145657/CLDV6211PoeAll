using System;
using System.Collections.Generic;

namespace St10145657_POEPart2.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public decimal? ProductPrice { get; set; }

    public int? StockQuantity { get; set; }

    public string? ImageUrl { get; set; }

    public int? Quantity { get; set; }

    public virtual Customer? Customer { get; set; }
}
