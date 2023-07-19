using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PayslipRepository : IPayslipRepository
    {
        public List<Payslip> GetPayslips() => PayslipDAO.GetPayslips();
    }
}
