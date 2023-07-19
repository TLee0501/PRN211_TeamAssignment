using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Payslip
    {
        public int Id { get; set; }
        public int? BasicSalary { get; set; }
        public int? Allowance { get; set; }
        public int? BonusOt { get; set; }
        public int? NetSalary { get; set; }
        public int? EmployeeId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
