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
        public List<Object> GetEmployees() => EmployeesDAO.GetEmployees();

        public void AddEmployee(Employee e) => EmployeesDAO.AddEmployee(e);
        public void UpdateEmployee(Employee e) => EmployeesDAO.UpdateEmployee(e);
        public void DeleteEmployee(Employee e) => EmployeesDAO.DeleteEmployee(e);
        public void AddSalary(Salary s) => EmployeesDAO.AddSalary(s);
        public void setRole(string role, int id) => EmployeesDAO.SetRole(role, id);
        public void setSalary(int salary, int id) => EmployeesDAO.setSalary(salary, id);
    }
}
