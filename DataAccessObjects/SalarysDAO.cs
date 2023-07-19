using BusinessObjects;
using BusinessObjects.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SalarysDAO
    {
        // Singleton
        private static SalarysDAO instance = null;
        private static readonly object instanceLock = new object();
        private SalarysDAO() { }
        public static SalarysDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SalarysDAO();
                    }
                    return instance;
                }
            }
        }

        //--------------------------------------------------------------------
        public CalculateSalaryViewModel ConfirmTime(int month, int year, int eID)
        {
            var viewModel = new CalculateSalaryViewModel();
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                //payslip
                //Payslip temp = new Payslip();
                var temp = context.Payslips.SingleOrDefault(a => a.EmployeeId == eID && a.Month == month && a.Year == year);
                if (temp != null)
                {
                    viewModel.Id = temp.Id;
                    viewModel.EmployeeId = eID;
                    viewModel.NetSalary = (int)temp.NetSalary;
                    viewModel.Bonus = (int)temp.BonusOt;
                    viewModel.Allowance = (int)temp.Allowance;
                }

                viewModel.EmployeeName = context.Employees.Find(eID).Name;
                if (String.IsNullOrEmpty(eID.ToString()) != true)
                {
                    viewModel.BasicSalary = (int)context.Salaries.SingleOrDefault(a => a.EmployeeId == eID).Amount;
                }
                else viewModel.BasicSalary = 0;

                //Lay-days
                //List<TakeLeave> takeleaves = new List<TakeLeave>();
                var takeleaves = context.TakeLeaves.Where(a => a.StartDate.Value.Month.Equals(month) && a.StartDate.Value.Year.Equals(year) && a.EmployeeId == eID && a.IsAccept == true).ToList();
                int layDay = 0;
                if (takeleaves != null)
                {
                    foreach (var item1 in takeleaves)
                    {
                        layDay += int.Parse((item1.EndDate - item1.StartDate).Value.TotalDays.ToString());
                    }
                    viewModel.LayDays = layDay;
                }

                //OT
                //List<Overtime> OTs = new List<Overtime>();
                var OTs = context.Overtimes.Where(a => a.Date.Value.Month.Equals(month) && a.Date.Value.Year.Equals(year) && a.EmployeeId == eID).ToList();
                var OTTotal = 0;
                if (OTs != null)
                {
                    foreach (var item1 in OTs)
                    {
                        OTTotal += (int)item1.Time;
                    }
                    viewModel.OT = OTTotal;
                }            }
            return viewModel;

        }

        public void SaveSalary(Payslip payslip)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.Payslips.Add(payslip);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateSalary(Payslip payslip)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.Entry<Payslip>(payslip).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PayrollViewModel> GetPayrolls()
        {
            var result = new List<PayrollViewModel>();
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    var payslips = context.Payslips.ToList();
                    foreach (var item in payslips)
                    {
                        var temp = new PayrollViewModel();
                        temp.Id = (int)item.EmployeeId;
                        temp.Name = context.Employees.Find(item.EmployeeId).Name;
                        temp.BasicSalary = (int)item.BasicSalary;
                        temp.NetSalary = (int)item.NetSalary;
                        temp.Month = (int)item.Month;
                        temp.Year = (int)item.Year;
                        result.Add(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
