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
                using(var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.TakeLeaves.Add(takeLeave);
                    context.SaveChanges();

                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
