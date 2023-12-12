using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsComment
{
    public int CommentId { get; set; }

    public int PostedBy { get; set; }

    public string PostedByName { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime PostTime { get; set; }
}
