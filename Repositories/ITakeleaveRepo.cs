
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

        
        int CountTakeLeaveInYear(int id, int year);
        int CountDayTakeLeave(int employeeId, int year);
        List<TakeLeave> GetTakeLeavesByEmployeeId(int employeeId);

        IEnumerable<TakeLeaveViewModel> GetTakeLeaves();
        void Reject(int id);
        void Accept(int id);

    }
}
