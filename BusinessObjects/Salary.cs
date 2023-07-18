using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Salary
    {
        public int Id { get; set; }
        public int? Amount { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
