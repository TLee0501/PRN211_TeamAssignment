using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class EmployeeDAO
    {
        // Singleton
        private static EmployeeDAO instance = null;
        private static readonly object instanceLock = new object();
        private EmployeeDAO() { }
        public static EmployeeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeDAO();
                    }
                    return instance;
                }
            }
        }

        //--------------------------------------------------------------------
        public List<Employee> GetEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    listEmployees = context.Employees.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listEmployees;
        }

        public Employee Login(string username, string password)
        {
            Employee employee = null;
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    employee = context.Employees.SingleOrDefault(m => m.Username.Equals(username) && m.Password.Equals(password));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employee;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    employee = context.Employees.SingleOrDefault(m => m.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    var p1 = context.Employees.SingleOrDefault(m => m.Id == employee.Id);
                    context.Employees.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    context.Entry<Employee>(employee).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
