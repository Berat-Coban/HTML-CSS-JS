using System;
using System.Collections.Generic;

namespace Yeni_klasör.Models.Entites;

public partial class Todo
{
    public int İd { get; set; }

    public ulong? IsComplated { get; set; }

    public string? Title { get; set; }
}
