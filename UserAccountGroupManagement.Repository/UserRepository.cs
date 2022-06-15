using System;
using System.Collections.Generic;
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
    public class UserRepository
    {
        public List<int> Errors = null;
        public User TheUser = new User();
        public UserAccount TheUserAccount = new UserAccount();
        public List<Group> TheGroups = new List<Group>();
        public bool InsertUser()
        {
            bool result = false;
            Errors = new List<int>();
            UserDBDataContext dc = null;
            long? id = 0;
            long? account_id = 0;
            int? error_num = 0;
            DateTime created = DateTime.Now;
            XElement groupIDXml = null;
            
            try
            {
                if (ValidateBeforeInsertUpdateUser())
                {
                    dc = new UserDBDataContext(Common.ConnectionStr);
                    GroupReopistory groupReopistory = new GroupReopistory();
                    groupIDXml = groupReopistory.GroupIDsToXML(TheGroups);

                    dc.st_user_insert(ref id, TheUser.FirstName, TheUser.MiddleName, TheUser.LastName
                                        , TheUser.DOB, groupIDXml
                                        , ref account_id, TheUserAccount.LoginName, TheUserAccount.Password, TheUserAccount.PasswordSalt, TheUserAccount.Status, ref error_num, created);

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
            }

            return result;
        }

        public bool UpdateUser()
        {
            bool result = false;
            Errors = new List<int>();
            UserDBDataContext dc = null;
            int? error_num = 0;
            DateTime modified = DateTime.Now;
            XElement groupIDXml = null;

            try
            {
                if (ValidateBeforeInsertUpdateUser())
                {
                    dc = new UserDBDataContext(Common.ConnectionStr);
                    GroupReopistory groupReopistory = new GroupReopistory();
                    groupIDXml = groupReopistory.GroupIDsToXML(TheGroups);

                    dc.st_user_update(TheUser.ID, TheUser.FirstName, TheUser.MiddleName, TheUser.LastName
                                        , TheUser.DOB, groupIDXml
                                        , TheUserAccount.ID, TheUserAccount.Password, TheUserAccount.PasswordSalt, TheUserAccount.Status, ref error_num, modified);

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
            }

            return result;
        }

        public bool ValidateBeforeInsertUpdateUser()
        {
            bool result = true;

            if (string.IsNullOrEmpty(TheUser.FirstName))
            {
                Errors.Add((int)UserError.FirstNameNullOrEmptyError);
            }

            if (string.IsNullOrEmpty(TheUser.LastName))
            {
                Errors.Add((int)UserError.LastNameNullOrEmptyError);
            }

            if (TheUser.DOB == null)
            {
                Errors.Add((int)UserError.DOBNullError);
            }


            if (string.IsNullOrEmpty(TheUserAccount.LoginName))
            {
                Errors.Add((int)UserError.LoginNameNullOrEmptyError);
            }

            if (string.IsNullOrEmpty(TheUserAccount.Password))
            {
                Errors.Add((int)UserError.PasswordNullOrEmptyError);
            }


            if(TheGroups == null || (TheGroups != null && TheGroups.Count == 0))
            {
                Errors.Add((int)UserError.UserGroupEmptyError);
            }

            if (Errors.Count == 0)
                result = true;

            return result;
        }



    }
}
