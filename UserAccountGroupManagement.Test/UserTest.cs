using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserAccountGroupManagement.Model;
using UserAccountGroupManagement.Repository;
using System.Collections.Generic;

namespace UserAccountGroupManagement.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void Test_2000_InsertUser()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(0, "Linda", "", "Smith", new DateTime(1996,1,1));
            UserAccount userAccount = new UserAccount(0, "linda.smith@gmail.com", "@Passord1", "PasswordSalt", 'A');

            List<Group> theGroups = new List<Group>();

            Group theGroup = new Group(1, "Administrator", "");
            theGroups.Add(theGroup);
            theGroup = new Group(2, "Staff", "");
            theGroups.Add(theGroup);

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;
            userRep.TheGroups = theGroups;
            result = userRep.InsertUser();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2001_InsertUserUserNameExist()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(0, "Linda", "", "Smith", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(0, "linda.smith@gmail.com", "@Passord1", "PasswordSalt", 'A');

            List<Group> theGroups = new List<Group>();

            Group theGroup = new Group(1, "Administrator", "");
            theGroups.Add(theGroup);
            theGroup = new Group(2, "Staff", "");
            theGroups.Add(theGroup);

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;
            userRep.TheGroups = theGroups;
            result = userRep.InsertUser();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2002_InsertAnotherUser()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(0, "Jenny", "", "Smith", new DateTime(1996, 12, 1));
            UserAccount userAccount = new UserAccount(0, "jenny.smith@gmail.com", "@Passord1", "PasswordSalt", 'A');

            List<Group> theGroups = new List<Group>();

            Group theGroup = new Group(1, "Administrator", "");
            theGroups.Add(theGroup);
            theGroup = new Group(2, "Staff", "");
            theGroups.Add(theGroup);

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;
            userRep.TheGroups = theGroups;
            result = userRep.InsertUser();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2003_UpdatetUser()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "@Passord1", "1PasswordSalt", 'A');

            List<Group> theGroups = new List<Group>();

            Group theGroup = new Group(1, "Administrator", "");
            theGroups.Add(theGroup);
            theGroup = new Group(2, "Staff", "");
            theGroups.Add(theGroup);

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;
            userRep.TheGroups = theGroups;
            result = userRep.UpdateUser();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2004_UpdatetUserGroupsHasChange()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "@Passord1", "1PasswordSalt", 'A');

            List<Group> theGroups = new List<Group>();

            Group theGroup = new Group(1, "Administrator", "");
            theGroups.Add(theGroup);
            //theGroup = new Group(2, "Staff", "");
            //theGroups.Add(theGroup);

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;
            userRep.TheGroups = theGroups;
            result = userRep.UpdateUser();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2005_UpdatetUserClearGroup()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "@Passord1", "1PasswordSalt", 'A');

            List<Group> theGroups = new List<Group>();

            //Group theGroup = new Group(1, "Administrator", "");
            //theGroups.Add(theGroup);
            //theGroup = new Group(2, "Staff", "");
            //theGroups.Add(theGroup);

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;
            userRep.TheGroups = theGroups;
            result = userRep.UpdateUser();

            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void Test_2006_UserList()
        {
            bool result = false;

            UserRepository userRepository = new UserRepository();
            List<UserSearchResult> lsResult = userRepository.UserList();

            if (lsResult != null && lsResult.Count > 0)
            {
                result = true;
            }

            Assert.AreEqual(true, result);
        }

      
        [TestMethod]
        public void Test_2007_DeleteGroupInUse()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.ID = 2;
            gr.TheGroup = g;

            result = gr.DeleteGroup();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test_2008_DeleteGroupNotInUse()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.ID = 3;
            gr.TheGroup = g;

            result = gr.DeleteGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2009_DeleteUser()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "1Password", "1PasswordSalt", 'A');

            userRep.TheUser = user;
            userRep.TheUserAccount = userAccount;

            result = userRep.DeleteUser();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2010_PasswordIsStrong()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            string password = "@Passord1";
            result = userRep.IsPasswordStrong(password);
            

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2011_PasswordIsNotStrong()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            string password = "Passord1";
            result = userRep.IsPasswordStrong(password);


            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2012_UserGroupsByUserID()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            long userID = 2;

            List<Group> groups = gr.UserGroupsByUserID(userID);
            if (groups != null && groups.Count > 0)
            {
                result = true;
            }

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2013_UserByID()
        {
            bool result = false;

            UserRepository ur = new UserRepository();
            long userID = 2;
            result = ur.UserByID(userID);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_2013_UserByIDNotExist()
        {
            bool result = false;

            UserRepository ur = new UserRepository();
            long userID = 1000;
            result = ur.UserByID(userID);

            Assert.AreEqual(true, result);
        }
    }
}
