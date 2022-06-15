using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountGroupManagement.Model
{
    public class User
    {
        public User()
        {

        }
        public User(long id, string firstName, string middleName, string lastName, DateTime dob)
        {
            ID = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DOB = dob;
        }
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}
