using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountGroupManagement.Util
{
    public class Common
    {
        private static string CONNECTION_STR_KEY = ConfigurationManager.AppSettings["CONNECTION_STR_KEY"];

        public static string ConnectionStr
        {
            get
            {
                string result = ConfigurationManager.ConnectionStrings[CONNECTION_STR_KEY].ConnectionString;
                return result;
            }
        }
    }


}
