using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class CampLeed
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Contact { get; set; }

    public string? Desc { get; set; }
}
