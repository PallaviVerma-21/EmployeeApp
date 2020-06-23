using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.DataModel;

namespace EmployeeApp.BusinessLogic
{
    public class EmployeeInfoHandler
    {
        public EmployeeInfoHandler()
        {
        }
        public  void DisplayEmployees()
        {
            List<PersonalDetail> employeeList = new List<PersonalDetail>();
            AuditDetails firstEmpAuditDetails = new AuditDetails("pVerma", DateTime.Today.Date.TimeOfDay);
            AuditDetails secondEmpAuditDetails = new AuditDetails("mSingh", DateTime.Today.Date.TimeOfDay);
            AuditDetails thirdEmpAuditDetails = new AuditDetails("wLou", DateTime.Today.Date.TimeOfDay);
            ProfessionalDetails firstEmpProfessionalDetails = new ProfessionalDetails(true, "IT");
            ProfessionalDetails secondEmpProfessionalDetails = new ProfessionalDetails(true, "Sales");
            ProfessionalDetails thirdEmpProfessionalDetails = new ProfessionalDetails(true, "Operations");
            ProfessionalDetails fourthEmpProfessionalDetails = new ProfessionalDetails(true, "Sales");
            PersonalDetail firstEmployee = new PersonalDetail(1, "Pallavi", "Verma", "BR6 7AE", "London", EmploymentType.FullTime, firstEmpAuditDetails, firstEmpProfessionalDetails);
            PersonalDetail secondEmployee = new PersonalDetail(2, "Mridul", "Singh", "BR6 7AE", "Bromley", EmploymentType.FullTime, secondEmpAuditDetails, secondEmpProfessionalDetails);
            PersonalDetail thirdEmployee = new PersonalDetail(3, "Lou", "Wiseman", "BR6 7DE", "Orpington", EmploymentType.FullTime, thirdEmpAuditDetails, thirdEmpProfessionalDetails);
            PersonalDetail fourthEmployee = new PersonalDetail(2, "Vedant", "Raj", "BR6 7AE", "Bromley", EmploymentType.FullTime, secondEmpAuditDetails, secondEmpProfessionalDetails);
            employeeList.Add(firstEmployee);
            employeeList.Add(secondEmployee);
            employeeList.Add(thirdEmployee);
            employeeList.Add(fourthEmployee);
            /* 1.Display all employee attributes provided in requirement section
            Employee Name, Address, Employment Type, Manager, Department, UserID and LoginTime */
            foreach (PersonalDetail p in employeeList)
            {
              
                string isManager = String.Empty;
                if (p.ProfessionalDetails.Manager)
                {
                    isManager = "Yes";
                }
                else
                {
                    isManager = "No";
                }
                Console.WriteLine($@"Employee Name :{p.FirstName} {p.LastName}");
                Console.WriteLine($@"Address :{p.ZipCode} {p.City}");
                Console.WriteLine($@"Employment Type :{p.EmploymentType}");
                Console.WriteLine($@"Manager :{isManager}");
                Console.WriteLine($@"Department :{p.ProfessionalDetails.Department}");
                Console.WriteLine($@"UserID :{p.AuditDetails.UserID}");
                Console.WriteLine($@"LoginTime :{p.AuditDetails.LoginTime.ToString()}");
                Console.ReadLine();
            }

            //2.	Display all departments and their employees
            foreach (var d in employeeList)
            {
                Console.WriteLine($@"Department Name: {d.ProfessionalDetails.Department}, Employee Name :{d.FirstName} {d.LastName}");
                Console.ReadLine();
            }
            //3.Display department with maximum number of employees
            var dept = (from department in employeeList
                        group department by new { department.ProfessionalDetails.Department } into deptGroup
                        select new
                        {
                            DepartmentName = deptGroup.Key.Department,
                            Count = deptGroup.Count(),
                        }).ToList();            
            foreach (var d in dept)
            {
                Console.WriteLine($@"Department Name : {d.DepartmentName}, Employee Count : {d.Count.ToString()}");
                Console.ReadLine();
            }
        }
    }
}
