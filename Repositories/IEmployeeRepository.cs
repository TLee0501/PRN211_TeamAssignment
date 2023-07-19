using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEmployeeRepository
    {
        List<Object> GetEmployees();
        void AddEmployee(Employee e);
        void UpdateEmployee(Employee e);
        void DeleteEmployee(Employee e);
        void AddSalary(Salary s);
        void setRole(string role, int id);
        void setSalary(int salary, int id);
    }
}
