using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsLeed
{
    public int LeedId { get; set; }

    public string? LeedDate { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Documentype { get; set; } = null!;

    public string Level { get; set; } = null!;

    public string DueDate { get; set; } = null!;

    public string Hours { get; set; } = null!;

    public string Pageno { get; set; } = null!;

    public string Price { get; set; } = null!;

    public int SellerId { get; set; }

    public string Status { get; set; } = null!;

    public string? Comment { get; set; }

    public string? CommentBy { get; set; }

    public string SourceSite { get; set; } = null!;
}
