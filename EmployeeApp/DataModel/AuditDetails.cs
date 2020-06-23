using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DataModel
{//Audit Detail: (UserID, LoginTime)
    public class AuditDetails
    {
        private string userID;
        private TimeSpan loginTime;

        public AuditDetails(string userID, TimeSpan loginTime)
        {
            this.userID = userID;
            this.loginTime = loginTime;
        }

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }
        public TimeSpan LoginTime
        {
            get
            {
                return loginTime;
            }
            set
            {

                loginTime = value;

            }
        }
    }
}
