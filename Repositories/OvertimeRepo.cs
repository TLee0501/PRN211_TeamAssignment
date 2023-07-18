using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OvertimeRepo : IOvertimeRepo
    {
        public void addOverTime(Overtime overtime) => OverTimeDAO.Instance.addEmployeeOverTime(overtime);
        public void Delete(Overtime overtime) => OverTimeDAO.Instance.Delete(overtime);
        public IEnumerable<Overtime> GetOvertimes() => OverTimeDAO.Instance.GetOvertimes();
    }
}
