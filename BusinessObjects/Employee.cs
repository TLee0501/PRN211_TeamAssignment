using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Employee
    {
        public Employee()
        {
            Attendances = new HashSet<Attendance>();
            Overtimes = new HashSet<Overtime>();
            Payslips = new HashSet<Payslip>();
            Salaries = new HashSet<Salary>();
            TakeLeaveCounts = new HashSet<TakeLeaveCount>();
            TakeLeaves = new HashSet<TakeLeave>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Overtime> Overtimes { get; set; }
        public virtual ICollection<Payslip> Payslips { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<TakeLeaveCount> TakeLeaveCounts { get; set; }
        public virtual ICollection<TakeLeave> TakeLeaves { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
