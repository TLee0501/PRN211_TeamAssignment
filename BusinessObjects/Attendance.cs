using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsAttend { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
