using BusinessObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class EmployeesDAO
    {
        public static List<Object> GetEmployees()
        {
            List<Object> employees = new List<Object>();
            try
            {
                string s = "SELECT ID, Name, Status, RoleName From Employee";
                DbProviderFactory factory = SqlClientFactory.Instance;
                using DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = GetConnection.GetConnectionString();
                connection.Open();
                DbCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandText = s;
                DbDataReader reader = cmd.ExecuteReader();
                foreach (object t in reader)
                {
                    employees.Add(t);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employees;
        }

        public static void AddEmployee(Employee e)
        {
            try
            {
                using var db = new PRN211_IT_HR_Management_SystemContext();
                db.Employees.Add(e);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteEmployee(Employee e)
        {
            try
            {
                using var db = new PRN211_IT_HR_Management_SystemContext();
                var tmp = db.Employees.SingleOrDefault(t => t.Id == e.Id);
                db.Employees.Remove(tmp);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateEmployee(Employee e)
        {
            try
            {
                using var db = new PRN211_IT_HR_Management_SystemContext();
                db.Entry<Employee>(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void AddSalary(Salary s)
        {
            try
            {
                using var db = new PRN211_IT_HR_Management_SystemContext();
                db.Salaries.Add(s);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
