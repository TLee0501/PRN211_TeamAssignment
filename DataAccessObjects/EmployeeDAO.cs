﻿using BusinessObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class EmployeeDAO
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
    }
}
