using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsUser
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string ConfirmationKey { get; set; } = null!;

    public string Confirmed { get; set; } = null!;

    public string PasswordResetKey { get; set; } = null!;

    public string PasswordResetConfirmed { get; set; } = null!;

    public DateTime? PasswordResetTimestamp { get; set; }

    public DateTime RegisterDate { get; set; }

    public int UserRole { get; set; }

    public DateTime? LastLogin { get; set; }

    public string Banned { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public string? ProfileImage { get; set; }
}
