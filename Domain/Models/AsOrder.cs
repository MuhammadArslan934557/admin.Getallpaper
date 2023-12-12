using System;
using System.Collections.Generic;

namespace Getallpaper_admin.Models;

public partial class AsOrder
{
    public int Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public string OrderId { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? OtherDueDate { get; set; }

    public string? Hours { get; set; }

    public string? Title { get; set; }

    public string? Subject { get; set; }

    public string? OtherSubject { get; set; }

    public string? Citation { get; set; }

    public string? OtherCitation { get; set; }

    public string? RequiredSource { get; set; }

    public string? Description { get; set; }

    public string Level { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Pages { get; set; } = null!;

    public string Price { get; set; } = null!;

    public int Discount { get; set; }

    public string Payment { get; set; } = null!;

    public int SellerId { get; set; }

    public string Status { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public string CommentBy { get; set; } = null!;

    public string Verified { get; set; } = null!;

    public DateTime? VerifiedDate { get; set; }

    public string VerifiedBy { get; set; } = null!;

    public int Closed { get; set; }

    public int WriterId { get; set; }

    public string OrderStatus { get; set; } = null!;

    public string WriterDate { get; set; } = null!;

    public string WriterHours { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string NoteBy { get; set; } = null!;

    public string? SourceSite { get; set; }
}
