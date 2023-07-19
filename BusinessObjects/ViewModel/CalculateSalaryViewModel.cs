using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.ViewModel
{
    public class CalculateSalaryViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int BasicSalary { get; set; }
        public int NetSalary { get; set;}
        public int LayDays { get; set; }
        public int OT { get; set;}
        public int Bonus { get; set;}
        public int Allowance { get; set; }
    }
}
