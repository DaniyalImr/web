﻿using System;
using System.Collections.Generic;

namespace web.Models;

public partial class Table
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Semester { get; set; }

    public int? Age { get; set; }

    public string? Contact { get; set; }
}