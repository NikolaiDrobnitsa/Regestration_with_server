using Dapper;
using Dapper.Contrib.Extensions;
using PInvoke;
using Regestration_with_server.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regestration_with_server.Controller
{
    internal class RegestrationController
    {
        public RegestrationController()
        {

        }
        public void Regestration(string _login, string _pass)
        {

            
            string connectionString = @"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Users regestration = new Users() { login = _login, password_hesh = new Text_crypt().Generate(_pass) };
                connection.Execute("INSERT INTO Users (login, password_hesh) VALUES(@login,@password_hesh)", regestration);
            }

        }
        
    }
}
