using System;
using System.Collections.Generic;

namespace Paramotor.Models.Entities;

public partial class User
{
    public int Id { get; set; }

    public string User1 { get; set; } = null!;

    public string Password { get; set; } = null!;
}
