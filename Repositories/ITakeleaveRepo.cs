using BusinessObjects;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ITakeleaveRepo
    {
        IEnumerable<TakeLeave> GetTakeLeaves();
        //void Create(Overtime overtime);
        //void Update(Overtime overtime);
        void AddTakeLeave(TakeLeave takeLeave);
        void Delete(TakeLeave takeLeave);
        int CountTakeLeaveInMonth(int id);
    }
}
