using BusinessObjects;
using BusinessObjects.ViewModel;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TakeLeaveRepo : ITakeLeaveRepo
    {
        public void AddTakeLeave(TakeLeave takeLeave) => TakeLeaveDAO.addTakeLeave(takeLeave);
        public void Delete(TakeLeaveViewModel takeLeave) => TakeLeaveDAO.Instance.Delete(takeLeave);
        public IEnumerable<TakeLeaveViewModel> GetTakeLeaves() => TakeLeaveDAO.Instance.GetTakeLeaves();
    }
}
