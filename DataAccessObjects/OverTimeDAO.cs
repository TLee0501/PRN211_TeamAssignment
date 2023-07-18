using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OverTimeDAO
    {
        private static OverTimeDAO instance = null;
        private static readonly object instanceLock = new object();
        private OverTimeDAO() { }
        public static OverTimeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OverTimeDAO();
                    }
                    return instance;
                }
            }
        }
        public void addEmployeeOverTime(Overtime overtime)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.Overtimes.Add(overtime);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public List<Overtime> GetOvertimes()

        {
            List<Overtime> overtimes = new List<Overtime>();
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                overtimes = context.Overtimes.ToList();
            }
            return overtimes;
        }
        public void Delete(Overtime overtime)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.Overtimes.Remove(overtime);
                context.SaveChanges();
            }
        }
    }
} 
