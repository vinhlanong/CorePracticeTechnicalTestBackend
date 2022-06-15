using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountGroupManagement.Error
{
    public enum UserError
    {
        InsertUserAccountError = -2000
        , InsertUserError = -2001
        , InsertUserGroupLinkError = -2002
        , UserNameAlreadyExist = -2003
        , DBUnexpectedError = -2004
        , UpdateUserAccountError = -2005
        , UpdateUserError = -2006
        , UpdateUserGroupLinkError = -2007

        , FirstNameNullOrEmptyError = 2000
        , LastNameNullOrEmptyError = 2001
        , DOBNullError = 2002

        , LoginNameNullOrEmptyError = 2003
        , PasswordNullOrEmptyError = 2004
        , UserGroupEmptyError = 2005

    }
}
