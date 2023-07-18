using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class LogOTRepo : ILogOTRepo
    {
        public void Create(Overtime overtime) => LogOTDAO.Instance.Create(overtime);

        public void Delete(Overtime overtime) => LogOTDAO.Instance.Delete(overtime);

        public IEnumerable<Overtime> GetOvertimes() => LogOTDAO.Instance.GetOvertimes();

        public void Update(Overtime overtime) => LogOTDAO.Instance.Update(overtime);
    }
}
