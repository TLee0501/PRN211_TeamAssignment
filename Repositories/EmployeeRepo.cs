using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public IEnumerable<Employee> GetEmployees() => EmployeeDAO.Instance.GetEmployees();
        public Employee GetEmployeeById(int id) => EmployeeDAO.Instance.GetEmployeeById(id);
        public void AddEmployee(Employee employee) => EmployeeDAO.Instance.AddEmployee(employee);
        public void DeleteEmployee(Employee employee) => EmployeeDAO.Instance.DeleteEmployee(employee);
        public void UpdateEmployee(Employee employee) => EmployeeDAO.Instance.UpdateEmployee(employee);
        public Employee Login(string username, string password) => EmployeeDAO.Instance.Login(username, password);
    }
}
