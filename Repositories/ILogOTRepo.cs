using BusinessObjects;
using BusinessObjects.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ILogOTRepo
    {
        IEnumerable<Overtime> GetOvertimes();
        void Create(Overtime overtime);
        void Update(Overtime overtime);
        void Delete(Overtime overtime);
    }
}
