using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DataModel
{
    public class PersonalDetail
    {//(EmployeeID, Name{FirstName, LastName}, address{ZipCode, City})
        //Employment Type: (Full Time/Part Time/Contractual/etc)
        private int employeeID;
        private string firstName;
        private string lastName;
        private string zipCode;
        private string city;
        private EmploymentType employmentType;
        private AuditDetails auditDetails;
        private ProfessionalDetails professionalDetails;
        public PersonalDetail()
        {

        }

        public PersonalDetail(int employeeID, string firstName, string lastName, string zipCode, string city, EmploymentType employmentType, AuditDetails auditDetails, ProfessionalDetails professionalDetails)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.zipCode = zipCode;
            this.city = city;
            this.employmentType = employmentType;
            this.auditDetails = auditDetails;
            this.professionalDetails = professionalDetails;
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        
        public EmploymentType EmploymentType
        {
            get
            {
                return employmentType;
            }
            set
            {
                employmentType = value;
            }
        }
        public AuditDetails AuditDetails
        {
            get
            {
                return auditDetails;
            }
            set
            {
                auditDetails = value;
            }
        }
        public ProfessionalDetails ProfessionalDetails
        {
            get
            {
                return professionalDetails;
            }
            set
            {
                professionalDetails = value;
            }
        }
    }
}
