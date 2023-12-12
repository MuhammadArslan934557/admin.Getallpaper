using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsLoginAttempt
{
    public int IdLoginAttempts { get; set; }

    public string IpAddr { get; set; } = null!;

    public int AttemptNumber { get; set; }

    public DateTime Date { get; set; }
}
