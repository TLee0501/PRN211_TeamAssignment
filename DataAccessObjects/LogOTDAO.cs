using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class LogOTDAO
    {
        // Singleton
        private static LogOTDAO instance = null;
        private static readonly object instanceLock = new object();
        private LogOTDAO() { }
        public static LogOTDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new LogOTDAO();
                    }
                    return instance;
                }
            }
        }

        //--------------------------------------------------------------------
        public List<Overtime> GetOvertimes()

        {
            List<Overtime> overtimes = new List<Overtime>();
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                overtimes = context.Overtimes.ToList();
            }
            return overtimes;

        }
        public void Create(Overtime overtime)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.Overtimes.Add(overtime);
                context.SaveChanges();
            }
        }
        public void Update(Overtime overtime)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.Overtimes.Update(overtime);
                context.SaveChanges();
            }
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
