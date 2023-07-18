using BusinessObjects;
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

    }
}
