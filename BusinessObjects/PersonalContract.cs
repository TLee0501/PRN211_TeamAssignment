using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class PersonalContract
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? BasicSalary { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
