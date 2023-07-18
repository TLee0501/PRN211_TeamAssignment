using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AttendanceDAO
    {
        private static AttendanceDAO instance = null;
        private static readonly object instanceLock = new object();
        private AttendanceDAO() { }
        public static AttendanceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AttendanceDAO();
                    }
                    return instance;
                }
            }
        }

        public void addAttendance(Attendance attendance)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.Attendances.Add(attendance);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public int GetMaxAttendanceId()
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                int? maxId = context.Attendances.Max(a => a.AttendanceId);
                return maxId.HasValue ? maxId.Value : 1;
            }
        }
        public bool CheckAttendanceToday(int employeeId)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {

                    DateTime today = DateTime.Today;
                    var attendances = context.Attendances.Where(a => a.EmployeeId == employeeId && a.Date.HasValue);
                    bool isExist = attendances.Any(a => a.Date.Value.Date == today);
                    return isExist;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
