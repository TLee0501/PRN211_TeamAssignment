using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class PayslipDAO
    {
        private static PayslipDAO instance = null;
        private static readonly object instanceLock = new object();
        private PayslipDAO() { }
        public static PayslipDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PayslipDAO();
                    }
                    return instance;
                }
            }
        }
        public Payslip GetPayslipByEmID(int EmployeeID)
        {
            Payslip payslip = new Payslip();
            try
            {
                using(var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    payslip = context.Payslips.SingleOrDefault(p => p.Employee.Id == EmployeeID);
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return payslip;
        }
    }

    
}
