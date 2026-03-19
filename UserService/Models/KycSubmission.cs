using System;
using System.Collections.Generic;

namespace UserService.Models;

public partial class KycSubmission
{
    public int Id { get; set; }

    public int AuthUserId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? RejectionReason { get; set; }

    public DateTime SubmittedAt { get; set; }

    public DateTime? ReviewedAt { get; set; }
}
