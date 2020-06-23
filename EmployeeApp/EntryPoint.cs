using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.BusinessLogic;

namespace EmployeeApp
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            EmployeeInfoHandler empInfo = new EmployeeInfoHandler();
            empInfo.DisplayEmployees();
        }
        
       
    }
}
