using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PayslipRepo : IPayslipRepo
    {
        public Payslip GetPayslipByEmID(int id) => PayslipDAO.Instance.GetPayslipByEmID(id);
    }
}
