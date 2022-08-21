using Dapper;
using Dapper.Contrib.Extensions;
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
    internal class AuthorizationController
    {
        public bool check_login { get; set; }
        public bool check_pass { get; set; }
        public AuthorizationController()
        {

        }

        public void Authorization(string auth_login, string auth_pass)
        {
            string connectionString = @"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    Users regestration = new Users() { email = _email, password = new Text_crypt().Generate(_pass) };
            //    connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
            //}
            //System.Windows.Forms.MessageBox.Show(new Text_crypt().Generate(auth_pass));
            check_login = false;
            check_pass = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    var myEvent = connection.QueryFirst<Users>(string.Format("SELECT * FROM Users WHERE login = '{0}'", auth_login));

                    if (new Text_crypt().Verification(auth_pass, myEvent.password_hesh))
                    {
                        System.Windows.Forms.MessageBox.Show("if");
                        check_pass = false;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("else");
                        check_pass = true;
                    }
                }
                catch
                {

                    check_login = true;
                }

                //try
                //{
                //    var myEvent = connection.QueryFirst<Users>(string.Format("SELECT * FROM Users WHERE password = '{0}'",auth_pass));
                //    //var myEvent = connection.QueryFirst<Users>(string.Format("SELECT * FROM Users WHERE email = '{0}'AND password = '{1}'",auth_email, auth_pass));




                //    //System.Windows.Forms.MessageBox.Show(myEvent.password);


                //}
                //catch
                //{
                //    //System.Windows.Forms.MessageBox.Show("Test_pass");
                //    check_pass = true;
                //}
            }
        }
    }
}
