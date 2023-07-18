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
    public class TakeLeaveRepo : ITakeleaveRepo
    {

        public void Delete(TakeLeave takeLeave) => TakeLeaveDAO.Instance.Delete(takeLeave);
        public void AddTakeLeave(TakeLeave takeLeave) => TakeLeaveDAO.Instance.addTakeLeave(takeLeave);
        public IEnumerable<TakeLeave> GetTakeLeaves() => TakeLeaveDAO.Instance.GetTakeLeaves();

        public int CountTakeLeaveInMonth(int id) => TakeLeaveDAO.Instance.CountTakeLeaveInMonth(id);

        public void AddTakeLeave(TakeLeave takeLeave) => TakeLeaveDAO.addTakeLeave(takeLeave);
        public void Reject(int id) => TakeLeaveDAO.Instance.Reject(id);
        public IEnumerable<TakeLeaveViewModel> GetTakeLeaves() => TakeLeaveDAO.Instance.GetTakeLeaves();
        public void Accept(int id) => TakeLeaveDAO.Instance.Accept(id);

    }
}