using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsNote
{
    public int Id { get; set; }

    public DateTime NoteDate { get; set; }

    public string OrderId { get; set; } = null!;

    public string OrderNote { get; set; } = null!;

    public string NoteBy { get; set; } = null!;
}
