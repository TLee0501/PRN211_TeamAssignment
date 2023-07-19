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
    public class OverTimeDAO
    {
        public static List<Object> GetOvertimes()
        {
            List<Object> overtimes = new List<Object>();
            try
            {
                string s = "SELECT o.ID, o.EmployeeID, e.Name, o.Date, o.Time\r\nFROM Overtime o, Employee e\r\nWHERE o.EmployeeID = e.ID";
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
                    overtimes.Add(t);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return overtimes;
        }
    }
}
