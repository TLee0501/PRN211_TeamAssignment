using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class TakeLeaveDAO
    {
        // Singleton
        private static TakeLeaveDAO instance = null;
        private static readonly object instanceLock = new object();
        private TakeLeaveDAO() { }
        public static TakeLeaveDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TakeLeaveDAO();
                    }
                    return instance;
                }
            }
        }

        //--------------------------------------------------------------------
        public List<TakeLeave> GetTakeLeaves()

        {
            List<TakeLeave> result = new List<TakeLeave>();
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                var takeLeaves = context.TakeLeaves.ToList();
                foreach (var item in takeLeaves)
                {
                    var temp = new TakeLeave();
                    temp.Id = item.Id;
                    temp.EmployeeId = item.EmployeeId;
                    temp.StartDate = item.StartDate;
                    temp.EndDate = item.EndDate;
                    temp.Description = item.Description;

                    var empName = context.Employees.SingleOrDefault(a => a.Id == item.EmployeeId).Name;
                    temp.Employee.Name = empName;

                    result.Add(temp);
                }
            }
            return result;

        }

        public void addTakeLeave(TakeLeave takeLeave)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.TakeLeaves.Add(takeLeave);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(TakeLeave takeLeave)
        {
            var objectDelete = new TakeLeave();
            objectDelete.Id = takeLeave.Id;
            objectDelete.EmployeeId = takeLeave.EmployeeId;
            objectDelete.StartDate = takeLeave.StartDate;
            objectDelete.EndDate = takeLeave.EndDate;
            objectDelete.Description = takeLeave.Description;
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.TakeLeaves.Remove(objectDelete);
                context.SaveChanges();
            }
        }
    }
}
