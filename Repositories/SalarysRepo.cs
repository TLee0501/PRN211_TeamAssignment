using BusinessObjects;
using BusinessObjects.ViewModel;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SalarysRepo : ISalarysRepo
    {
        public CalculateSalaryViewModel ConfirmTime(int month, int year, int eID) => SalarysDAO.Instance.ConfirmTime(month, year, eID);

        public IEnumerable<PayrollViewModel> GetPayslips() => SalarysDAO.Instance.GetPayrolls();

        public void SaveSalary(Payslip payslip) => SalarysDAO.Instance.SaveSalary(payslip);

        public void UpdateSalary(Payslip payslip) => SalarysDAO.Instance.UpdateSalary(payslip);
    }
}
