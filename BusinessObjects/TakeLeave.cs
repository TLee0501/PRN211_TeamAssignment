using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TakeLeave
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
