using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsBlog
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? WrittenBy { get; set; }

    public string? PublishedOn { get; set; }

    public string? Url { get; set; }
}
