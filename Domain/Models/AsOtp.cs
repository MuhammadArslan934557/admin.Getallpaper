using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsOtp
{
    public int OtpId { get; set; }

    public string Otp { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;
}
