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

        
        
        

        public int CountTakeLeaveInMonth(int id) => TakeLeaveDAO.Instance.CountTakeLeaveInMonth(id);

        public void AddTakeLeave(TakeLeave takeLeave) => TakeLeaveDAO.addTakeLeave(takeLeave);
        public void Reject(int id) => TakeLeaveDAO.Instance.Reject(id);
        public IEnumerable<TakeLeaveViewModel> GetTakeLeaves() => TakeLeaveDAO.Instance.GetTakeLeaves();
        public void Accept(int id) => TakeLeaveDAO.Instance.Accept(id);

    }
}