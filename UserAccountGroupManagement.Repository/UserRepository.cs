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
using System.Data.Linq;


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

        //---
        public bool DeleteUser()
        {
            bool result = false;
            Errors = new List<int>();
            UserDBDataContext dc = null;
            int? error_num = 0;

            try
            {
                if (ValidateBeforeDelete())
                {
                    dc = new UserDBDataContext(Common.ConnectionStr);
                    dc.st_user_delete(TheUser.ID, TheUserAccount.ID, ref error_num);

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
            bool result = false;

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

            if (!IsPasswordStrong(TheUserAccount.Password))
            {
                Errors.Add((int)UserError.PasswordNotStrongError);
            }


            //if(TheGroups == null || (TheGroups != null && TheGroups.Count == 0))
            //{
            //    Errors.Add((int)UserError.UserGroupEmptyError);
            //}

            if (Errors.Count == 0)
                result = true;

            return result;
        }

        public bool ValidateBeforeDelete()
        {
            bool result = true;

            if (TheUser.ID <=0)
            {
                Errors.Add((int)UserError.InvalidUserIDError);
            }

            if (TheUserAccount.ID <=0 )
            {
                Errors.Add((int)UserError.InvalidUserAccountIDError);
            }


            if (Errors.Count == 0)
                result = true;

            return result;
        }

        public List<UserSearchResult> UserList()
        {
            UserDBDataContext dc = null;
            List<UserSearchResult> lsResult = null;
            List<st_userList_selectResult> lsTmp = null;
            ISingleResult<st_userList_selectResult> sp = null;
            try
            {
                dc = new UserDBDataContext(Common.ConnectionStr);
                sp = dc.st_userList_select();
                lsTmp = sp.ToList();
                lsResult = ConvertUserList(lsTmp);
            }
            catch (Exception ex)
            {

            }
            return lsResult;
        }

        List<UserSearchResult> ConvertUserList(List<st_userList_selectResult> lsTmp)
        {
            List<UserSearchResult> lsResult = null;
            UserSearchResult userSearchResult = null;

            if (lsTmp != null && lsTmp.Count > 0)
            {
                lsResult = new List<UserSearchResult>();


                foreach (st_userList_selectResult c in lsTmp)
                {
                    userSearchResult = new UserSearchResult(c.id, c.first_name, c.middle_name, c.last_name, c.dob, c.login_name, c.created, c.status.Value);
                    lsResult.Add(userSearchResult);
                }
            }

            return lsResult;
        }

        /// <summary>
        /// must contains one digit from 0-9
        /// must contains one lowercase characters
        /// must contains one uppercase characters
        /// must contains one special symbols in the list "@#$%"
        /// match anything with previous condition checking
        /// length at least 8 characters and maximum of 40
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsPasswordStrong(string password)

        {
            bool result = false;
            result = System.Text.RegularExpressions.Regex.IsMatch(password, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,40})");

            return result;
        }
    }
}
