using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace hospital_management_system.classes
{
    class dbAccess
    {
        public List<EmployeeDetails> findAccount(string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<EmployeeDetails>($"SELECT * FROM dbo.EmployeeDetails WHERE Email = '{ email }' AND Password = '{ password }'");

                if (output.Count() == 1)
                {
                    return (List<EmployeeDetails>)output;
                }

                return null;
                
            }
        }
    }
}
