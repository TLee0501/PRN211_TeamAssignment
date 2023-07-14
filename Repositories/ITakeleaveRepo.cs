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
        IEnumerable<TakeLeaveViewModel> GetTakeLeaves();
        //void Create(Overtime overtime);
        //void Update(Overtime overtime);
        void Delete(TakeLeaveViewModel takeLeave);
    }
}
