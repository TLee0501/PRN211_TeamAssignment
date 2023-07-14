using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Payslip
    {
        public Guid Id { get; set; }
        public int? BasicSalary { get; set; }
        public int? Allowance { get; set; }
        public int? BonusOt { get; set; }
        public int? GrossSalary { get; set; }
        public Guid? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
