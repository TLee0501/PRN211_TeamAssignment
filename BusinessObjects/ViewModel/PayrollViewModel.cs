using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.ViewModel
{
    public class PayrollViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BasicSalary { get; set; }
        public int NetSalary { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
