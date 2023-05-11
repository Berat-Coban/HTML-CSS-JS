using System;
using System.Collections.Generic;

namespace Paramotor.Models.Entities;

public partial class Site
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? Email { get; set; }

    public string Description { get; set; } = null!;

    public string? Facebook { get; set; }

    public string? Tiwitter { get; set; }

    public string? Instagram { get; set; }

    public string? Youtube { get; set; }

    public string? Logoimage { get; set; }
}
