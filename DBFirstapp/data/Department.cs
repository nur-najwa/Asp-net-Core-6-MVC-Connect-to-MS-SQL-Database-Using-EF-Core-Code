using System;
using System.Collections.Generic;

namespace DBFirstapp.data;

public partial class Department
{
    public int Id { get; set; }

    public string? DepartmentName { get; set; }

    public int? Status { get; set; }

    public string? CreatedBy { get; set; }
}
