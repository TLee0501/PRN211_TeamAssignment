using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Object> GetEmployees() => EmployeeDAO.GetEmployees();

        public void AddEmployee(Employee e) => EmployeeDAO.AddEmployee(e);
        public void UpdateEmployee(Employee e) => EmployeeDAO.UpdateEmployee(e);
        public void DeleteEmployee(Employee e) => EmployeeDAO.DeleteEmployee(e);
        public void AddSalary(Salary s) => EmployeeDAO.AddSalary(s);
    }
}
