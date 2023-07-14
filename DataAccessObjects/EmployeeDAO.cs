using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class EmployeeDAO
    {
        public static Employee GetEmployeebyID(string username, string password)
        {
            Employee employee = new Employee();
            try
            {
                using(var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    employee = context.Employees.SingleOrDefault(m=>m.Username == username && m.Password == password);
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employee;
        }
    }
}
