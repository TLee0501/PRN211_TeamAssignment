using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOvertimeRepo
    {
        void addOverTime(Overtime overtime);
        IEnumerable<Overtime> GetOvertimes();
        void Delete(Overtime overtime);
    }
}
