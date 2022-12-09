using System;
using System.Collections.Generic;

namespace DBFirstapp.data;

public partial class EmployeeLogin
{
    public int Id { get; set; }

    public int? LoginId { get; set; }

    public string? Password { get; set; }

    public string? EmployeeName { get; set; }

    public int? DepartmentId { get; set; }
}
