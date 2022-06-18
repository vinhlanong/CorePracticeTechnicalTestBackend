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
        public void Test_1000_InsertGroup()
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
        public void Test_1001_InsertAnotherGroup()
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
        public void Test_1002_InsertAnotherGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.Name = "Delivery Team";
            g.Desc = "Delivery Team";
            gr.TheGroup = g;

            result = gr.InsertGroup();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_1003_InsertGroupDuplicateGroup()
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
        public void Test_1004_InsertGroupEmptyGroupName()
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
        public void Test_1005_UpdateGroup()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            Group g = new Group();
            g.ID = 2;
            g.Name = "Staff1";
            g.Desc = "Staff Group1";
            gr.TheGroup = g;

            result = gr.UpdateGroup();

            Assert.AreEqual(true, result);
        }

       

        [TestMethod]
        public void Test_1006_ListGroup()
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

        [TestMethod]
        public void Test_1007_GroupByID()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            short groupID = 1;

            Group group = gr.GroupByID(groupID);
            if(group != null)
            {
                result = true;
            }

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_1007_GroupByIDNotExist()
        {
            bool result = false;

            GroupReopistory gr = new GroupReopistory();
            short groupID = 4;

            Group group = gr.GroupByID(groupID);
            if (group != null)
            {
                result = true;
            }

            Assert.AreEqual(true, result);
        }




    }
}
