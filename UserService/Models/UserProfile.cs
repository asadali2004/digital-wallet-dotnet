using System;
using System.Collections.Generic;

namespace UserService.Models;

public partial class UserProfile
{
    public int Id { get; set; }

    public int AuthUserId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PinCode { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
