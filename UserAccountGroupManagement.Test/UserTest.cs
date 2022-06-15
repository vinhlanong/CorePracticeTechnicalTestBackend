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
        public void TestInsertUser()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(0, "Linda", "", "Smith", new DateTime(1996,1,1));
            UserAccount userAccount = new UserAccount(0, "linda.smith@gmail.com", "Password", "PasswordSalt", 'A');

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
        public void TestUpdatetUser()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "1Password", "1PasswordSalt", 'A');

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
        public void TestUpdatetUserGroupsHasChange()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "1Password", "1PasswordSalt", 'A');

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
        public void TestUpdatetUserClearGroup()
        {
            bool result = false;
            UserRepository userRep = new UserRepository();
            User user = new User(1, "Linda1", "", "Smith1", new DateTime(1996, 1, 1));
            UserAccount userAccount = new UserAccount(1, "1linda.smith@gmail.com", "1Password", "1PasswordSalt", 'A');

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
    }
}
