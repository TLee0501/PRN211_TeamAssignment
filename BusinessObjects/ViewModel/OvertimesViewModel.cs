using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.ViewModel
{
    public class OvertimesViewModel
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public string? EmployeeName { get; set; }
    }
}
