using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsTransaction
{
    public int TransId { get; set; }

    public string? UserEmail { get; set; }

    public string? OrderId { get; set; }

    public string? TotalAmount { get; set; }

    public string? PaidAmount { get; set; }

    public string? RemainingAmount { get; set; }

    public string? PaymentStatus { get; set; }

    public DateTime? TransDate { get; set; }

    public bool? DelStatus { get; set; }

    public string SourceSite { get; set; } = null!;
}
