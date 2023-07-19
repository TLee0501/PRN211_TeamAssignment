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





        public int CountTakeLeaveInYear(int id, int year) => TakeLeaveDAO.Instance.CountTakeLeaveInYear(id, year);

        public void AddTakeLeave(TakeLeave takeLeave) => TakeLeaveDAO.addTakeLeave(takeLeave);
        public void Reject(int id) => TakeLeaveDAO.Instance.Reject(id);
        public IEnumerable<TakeLeaveViewModel> GetTakeLeaves() => TakeLeaveDAO.Instance.GetTakeLeaves();
        public void Accept(int id) => TakeLeaveDAO.Instance.Accept(id);

        public int CountDayTakeLeave(int employeeId, int year) =>TakeLeaveDAO.Instance.CountDayTakeLeave(employeeId, year);

        public List<TakeLeave> GetTakeLeavesByEmployeeId(int employeeId) => TakeLeaveDAO.Instance.GetTakeLeavesByEmployeeId((int)employeeId);
    }
}