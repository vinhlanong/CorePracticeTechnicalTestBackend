using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserAccountGroupManagement.Model;
using UserAccountGroupManagement.Repository;

namespace UserAccountGroupManagement.Test
{
    [TestClass]
    public class UserGroupTest
    {
        [TestMethod]
        public void TestInsertGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.Name = "Administrator";
            g.Desc = "Administrator Group";
            gr.TheGroup = g;

            result = gr.InsertGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInsertGroupDuplicateGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.Name = "Administrator";
            g.Desc = "Administrator Group";
            gr.TheGroup = g;

            result = gr.InsertGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInsertAnotherGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.Name = "Staff";
            g.Desc = "Staff Group";
            gr.TheGroup = g;

            result = gr.InsertGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInsertGroupEmptyGroupName()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.Name = "";
            g.Desc = "Administrator Group";
            gr.TheGroup = g;

            result = gr.InsertGroup();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestUpdateGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.ID = 4;
            g.Name = "Staff1";
            g.Desc = "Staff Group1";
            gr.TheGroup = g;

            result = gr.UpdateGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestDeleteGroupInUse()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.ID = 4;
            gr.TheGroup = g;

            result = gr.DeleteGroup();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestDeleteGroupNotInUse()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.ID = 5;
            gr.TheGroup = g;

            result = gr.DeleteGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestListGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            List<Group> lsResult = gr.GroupList();

            if(lsResult != null && lsResult.Count > 0)
            {
                result = true;
            }

            Assert.AreEqual(true, result);
        }
    }
}
