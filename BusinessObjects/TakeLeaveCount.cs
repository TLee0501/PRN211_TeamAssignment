using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TakeLeaveCount
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Count { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
