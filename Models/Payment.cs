using System;
using System.Collections.Generic;

namespace St10145657_POEPart2.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? CustomerId { get; set; }

    public decimal Amount { get; set; }

    public virtual Customer? Customer { get; set; }
}
