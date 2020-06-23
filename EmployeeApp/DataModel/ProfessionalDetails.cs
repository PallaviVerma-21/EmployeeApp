using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Professional Detail: (Manager, Department)

namespace EmployeeApp.DataModel
{
    public class ProfessionalDetails
    { 

        private bool manager;
        private string department;

        public ProfessionalDetails(bool manager, string department)
        {
            this.manager = manager;
            this.department = department;
        }

        public bool Manager
        {
            get
            {
                return manager;
            }
            set
            {
                manager = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
    }
}
