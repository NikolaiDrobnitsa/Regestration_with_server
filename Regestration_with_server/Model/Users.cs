using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regestration_with_server.Model
{
    internal class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password_hesh { get; set; }
        public override string ToString()
        {
            return string.Format("id: {0}\tlogin: {1}\tpassword_hesh: {2}", id, login, password_hesh);
        }
        public Users()
        {

        }
    }
}
