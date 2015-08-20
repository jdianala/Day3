using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
//    Create a set of classes that satisfy the following requirements:

//FullTimeEmployee - A full time employee should have First Name, Last Name, and Years Employed properties.
//ContractEmployee - A contract employee should have First Name, Last Name, and Months Employed properties.
//All employees should have a method named ShowFullName() that displays the employee's full name (for example, "Bill Gates").
//Using Debug.Assert(), test your set of classes:

//Create a full time employee named Bill Gates who has worked for the company for 5 years.Use Debug.Assert() to verify that ShowFullName() returns "Bill Gates". Use a second Debug.Assert() to ensure that Years Employed is 5 years.
//Create a contract employee named Steve Jobs who has worked for the company for 2 months.Use Debug.Assert() to verify that ShowFullName() returns "Steve Jobs". Use a second Debug.Assert() to verify that Months Employed is 2 months.
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ShowFullName ()
            {          
                string output = String.Format("{0} {1}", FirstName, LastName);
                return output;
            }
        }

        class FullTimeEmployee : Employee
        {
            public int YearsEmployed { get; set; }
        }

        class ContractEmployee : Employee
        {
            public int MonthsEmployed { get; set; }
        }

        static void Main(string[] args)
        {


        }


    }

}
