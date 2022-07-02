using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseworkAD1.BusinessObjects
{
    public class UserBO
    {
        private string userid;
        private string email;
        private string password;
        private string type;

        public string Userid { get => userid; set => userid = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
    }
}
