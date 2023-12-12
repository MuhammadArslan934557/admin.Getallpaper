using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsRevision
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? RevDate { get; set; }

    public string Revid { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public string File { get; set; } = null!;

    public string Verified { get; set; } = null!;

    public DateTime VerifiedDate { get; set; }

    public string VerifiedBy { get; set; } = null!;
}
