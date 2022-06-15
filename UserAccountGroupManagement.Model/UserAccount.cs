using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountGroupManagement.Model
{
    public class UserAccount
    {
        public UserAccount()
        {

        }

        public UserAccount(long id, string loginName, string password, string passwordSalt, char status)
        {
            ID = id;
            LoginName = loginName;
            Password = password;
            PasswordSalt = passwordSalt;
            Status = status;
        }
        public long ID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public char Status { get; set; }
    }
}
