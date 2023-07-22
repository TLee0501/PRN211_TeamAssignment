using BusinessObjects;
using BusinessObjects.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class TakeLeaveDAO
    {
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

        public static void addTakeLeave(TakeLeave takeLeave)
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
        public List<TakeLeaveViewModel> GetTakeLeaves()
        {
            List<TakeLeaveViewModel> result = new List<TakeLeaveViewModel>();
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                var takeLeaves = context.TakeLeaves.ToList();
                foreach (var item in takeLeaves)
                {
                    var temp = new TakeLeaveViewModel();
                    temp.Id = item.Id;
                    temp.EmployeeId = item.EmployeeId;
                    temp.StartDate = item.StartDate;
                    temp.EndDate = item.EndDate;
                    temp.Description = item.Description;
                    temp.IsAccept = item.IsAccept;

                    var empName = context.Employees.SingleOrDefault(a => a.Id == item.EmployeeId).Name;
                    temp.EmployeeName = empName;

                    result.Add(temp);
                }
            }
            return result;

        }
        public void Reject(int id)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                var result = context.TakeLeaves.Find(id);
                result.IsAccept = false;
                context.Entry<TakeLeave>(result).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Accept(int id)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                var result = context.TakeLeaves.Find(id);
                result.IsAccept = true;
                context.Entry<TakeLeave>(result).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public int CountTakeLeaveInYear(int employeeId, int year)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    DateTime firstDayOfYear = new DateTime(year, 1, 1);
                    DateTime lastDayOfYear = new DateTime(year, 12, 31);

                    int numberOfTakeLeaves = context.TakeLeaves
                        .Where(tl => tl.EmployeeId == employeeId && tl.StartDate >= firstDayOfYear && tl.EndDate <= lastDayOfYear)
                        .Count();

                    return numberOfTakeLeaves;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int CountDayTakeLeave(int employeeId, int year)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    DateTime firstDayOfYear = new DateTime(year, 1, 1);
                    DateTime lastDayOfYear = new DateTime(year, 12, 31);

                    int totalDaysTakeLeave = context.TakeLeaves
                        .Where(tl => tl.EmployeeId == employeeId && tl.IsAccept == true && tl.StartDate >= firstDayOfYear && tl.EndDate <= lastDayOfYear)
                        .ToList()
                        .Sum(tl => (tl.EndDate - tl.StartDate)?.Days + 1 ) ?? 0;

                    return totalDaysTakeLeave;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<TakeLeave> GetTakeLeavesByEmployeeId(int employeeId)
        {
            try
            {
                using(var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    List<TakeLeave> takeLeaves = context.TakeLeaves
                    .Include(e => e.Employee)
                    .Where(tl => tl.EmployeeId == employeeId)
                    .ToList();

                return takeLeaves;
                }          
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}