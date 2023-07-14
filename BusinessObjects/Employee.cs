using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Employee
    {
        public Employee()
        {
            Overtimes = new HashSet<Overtime>();
            Payslips = new HashSet<Payslip>();
            PersonalContracts = new HashSet<PersonalContract>();
            TakeLeaves = new HashSet<TakeLeave>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Overtime> Overtimes { get; set; }
        public virtual ICollection<Payslip> Payslips { get; set; }
        public virtual ICollection<PersonalContract> PersonalContracts { get; set; }
        public virtual ICollection<TakeLeave> TakeLeaves { get; set; }
    }
}
