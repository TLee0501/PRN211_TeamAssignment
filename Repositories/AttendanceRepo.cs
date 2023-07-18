using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AttendanceRepo : IAttendanceRepo
    {
        public void addAttendance(Attendance attendance) => AttendanceDAO.Instance.addAttendance(attendance);

        public int GetMaxAttendanceID() => AttendanceDAO.Instance.GetMaxAttendanceId();

        public bool CheckAttendanceToDay(int id) => AttendanceDAO.Instance.CheckAttendanceToday(id);
    }
}
