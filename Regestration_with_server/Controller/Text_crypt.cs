using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regestration_with_server.Controller
{
    internal class Text_crypt
    {
        public string Generate(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }
        public bool Verification(string verif_pass, string server_pass)
        {
            return BCrypt.Net.BCrypt.Verify(verif_pass, server_pass);
        }

    }
}
