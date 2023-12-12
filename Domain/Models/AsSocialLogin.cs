using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsSocialLogin
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Provider { get; set; }

    public string? ProviderId { get; set; }

    public DateTime? CreatedAt { get; set; }
}
