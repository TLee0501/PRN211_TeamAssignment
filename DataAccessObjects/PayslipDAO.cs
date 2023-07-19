using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class PayslipDAO
    {
        public static List<Payslip> GetPayslips()
        {
            List<Payslip> list = new List<Payslip>();
            try
            {
                using var db = new PRN211_IT_HR_Management_SystemContext();
                list = db.Payslips.Include(p => p.Employee).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
    }
}
