using System;
using System.Collections.Generic;

namespace St10145657_POEPart2.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
