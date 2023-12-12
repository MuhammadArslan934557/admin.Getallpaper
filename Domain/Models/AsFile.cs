using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsFile
{
    public int Id { get; set; }

    public string OrderId { get; set; } = null!;

    public string? File { get; set; }

    public string? FinalFile { get; set; }
}
