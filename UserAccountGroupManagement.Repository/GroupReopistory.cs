using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccountGroupManagement.DAL;
using UserAccountGroupManagement.Error;
using UserAccountGroupManagement.Model;
using UserAccountGroupManagement.Util;

namespace UserAccountGroupManagement.Repository
{
    public class GroupReopistory
    {
        public Group TheGroup = new Group();

        public List<int> Errors = null;

        public bool InsertGroup()
        {
            bool result = false;
            Errors = new List<int>();
            GroupDBDataContext dc = null;
            long? id = 0;
            int? error_num = 0;
            DateTime created = DateTime.Now;

            try
            {
                if (ValidateBeforeInsertUpdateGroup())
                {
                    dc = new GroupDBDataContext(Common.ConnectionStr);

                    dc.st_userGroup_insert(ref id, TheGroup.Name, TheGroup.Desc, created, ref error_num);

                    if (error_num == 0)
                    {
                        result = true;
                    }
                    else
                        Errors.Add(error_num.Value);
                }
            }
            catch (Exception ex)
            {
                Errors.Add((int)CommonError.UnexpectError);

                //--log error
            }

            return result;
        }

        public bool UpdateGroup()
        {
            bool result = false;
            Errors = new List<int>();
            GroupDBDataContext dc = null;
            int? error_num = 0;
            DateTime modified = DateTime.Now;

            try
            {
                if (ValidateBeforeInsertUpdateGroup())
                {
                    dc = new GroupDBDataContext(Common.ConnectionStr);

                    dc.st_userGroup_update(TheGroup.ID, TheGroup.Name, TheGroup.Desc, modified, ref error_num);

                    if (error_num == 0)
                    {
                        result = true;
                    }
                    else
                        Errors.Add(error_num.Value);
                }
            }
            catch (Exception ex)
            {
                Errors.Add((int)CommonError.UnexpectError);

                //--log error
            }

            return result;
        }

        public bool DeleteGroup()
        {
            bool result = false;
            Errors = new List<int>();
            GroupDBDataContext dc = null;
            int? error_num = 0;
            DateTime modified = DateTime.Now;

            try
            {
                if (ValidateBeforeDeleteGroup())
                {
                    dc = new GroupDBDataContext(Common.ConnectionStr);

                    dc.st_userGroup_delete(TheGroup.ID, ref error_num);

                    if (error_num == 0)
                    {
                        result = true;
                    }
                    else
                        Errors.Add(error_num.Value);
                }
            }
            catch (Exception ex)
            {
                Errors.Add((int)CommonError.UnexpectError);

                //--log error
            }

            return result;
        }


        bool ValidateBeforeInsertUpdateGroup()
        {
            bool result = false;

            if (string.IsNullOrEmpty(TheGroup.Name))
            {
                Errors.Add((int)GroupError.GroupNameNullOrEmptyError);
            }

            if (Errors.Count == 0)
                result = true;


            return result;
        }

        bool ValidateBeforeDeleteGroup()
        {
            bool result = false;

            if (TheGroup.ID <=0)
            {
                Errors.Add((int)GroupError.InvalidIDError);
            }

            if (Errors.Count == 0)
                result = true;


            return result;
        }


        public List<Group> GroupList()
        {
            GroupDBDataContext dc = null;
            List<Group> lsResult = null;
            List<st_userGroupAll_selectResult> lsTmp = null;
            ISingleResult<st_userGroupAll_selectResult> sp = null;
            try
            {
                dc = new GroupDBDataContext(Common.ConnectionStr);
                sp = dc.st_userGroupAll_select();
                lsTmp = sp.ToList();
                lsResult = ConvertGroupList(lsTmp);
            }
            catch(Exception ex)
            {

            }
            return lsResult;
        }

        List<Group> ConvertGroupList(List<st_userGroupAll_selectResult> lsTmp)
        {
            List<Group> lsResult = null;
            Group group = null;

            if (lsTmp != null && lsTmp.Count > 0)
            {
                lsResult = new List<Group>();


                foreach (st_userGroupAll_selectResult c in lsTmp)
                {
                    group = new Group(c.id, c.group_name, c.description);
                    lsResult.Add(group);
                }
            }

            return lsResult;
        }

        public XElement GroupIDsToXML(List<Group> lsResult)
        {
            XElement result = null;

            if (lsResult != null && lsResult.Count > 0)
            {
                result = new XElement("root", from r in lsResult
                                              select new XElement("rec",
                                                                         new XElement("ID", r.ID)
                                                                 )
                          );
            }

            return result;
        }
    }
}
