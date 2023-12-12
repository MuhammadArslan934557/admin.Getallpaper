using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsUserDetail
{
    public int IdUserDetails { get; set; }

    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;
}
