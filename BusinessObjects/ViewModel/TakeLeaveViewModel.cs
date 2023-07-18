using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.ViewModel
{
    public class TakeLeaveViewModel
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public bool? IsAccept { get; set; }
    }
}
