using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDSReader
{
    public class checkUser
    {
        public string Login { get; set; }
        public bool IsAdmin { get; }
        public int IDuser { get; set; }
        
        public string Status => IsAdmin ? "Admin" : "User";
        public checkUser (string login, bool isAnmin, int iDuser)
        {
            Login = login.Trim();
            IsAdmin = isAnmin;
            IDuser = iDuser;
        }
    }
}
