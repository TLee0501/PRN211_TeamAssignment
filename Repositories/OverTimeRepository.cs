using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OverTimeRepository : IOverTimeRepository
    {
        public List<Object> GetOverTimes() => OverTimesDAO.GetOvertimes();
    }
}
