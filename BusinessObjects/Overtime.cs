using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Overtime
    {
        public Guid Id { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public Guid? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
