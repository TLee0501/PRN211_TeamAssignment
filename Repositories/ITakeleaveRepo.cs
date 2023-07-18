
using BusinessObjects;
using BusinessObjects.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ITakeleaveRepo
    {
        void AddTakeLeave(TakeLeave takeLeave);

        void Delete(TakeLeave takeLeave);
        int CountTakeLeaveInMonth(int id);

        IEnumerable<TakeLeaveViewModel> GetTakeLeaves();
        void Reject(int id);
        void Accept(int id);

    }
}
