using BusinessObjects;
using BusinessObjects.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISalarysRepo
    {
        CalculateSalaryViewModel ConfirmTime(int month, int year, int phone);
        void SaveSalary(Payslip payslip);
        void UpdateSalary(Payslip payslip);
        IEnumerable<PayrollViewModel> GetPayslips();
    }
}
