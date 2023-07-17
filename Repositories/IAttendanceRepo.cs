using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAttendanceRepo
    {
        void addAttendance(Attendance attendance);
        int GetMaxAttendanceID();
        Boolean CheckAttendanceToDay(int id);
    }
}
