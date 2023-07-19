using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class TakeLeavesDAO
    {
        public static List<TakeLeave> GetTakeLeaves()
        {
            var list = new List<TakeLeave>();
            try
            {
                using var db = new PRN211_IT_HR_Management_SystemContext();
                list = db.TakeLeaves.Include(t => t.Employee).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
    }
}
