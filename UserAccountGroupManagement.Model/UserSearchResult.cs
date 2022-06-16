using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountGroupManagement.Model
{
    public class UserSearchResult
    {
        public UserSearchResult()
        {

        }

        public UserSearchResult(long userID, string firstName, string middleName, string lastName, DateTime dob, string loginName, DateTime created, char status)
        {
            UserID = userID;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DOB = dob;
            LoginName = loginName;
            Created = created;
            Status = status;
        }

        public long UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string LoginName { get; set; }
        public DateTime Created { get; set; }
        public char Status { get; set; }
    }
}
