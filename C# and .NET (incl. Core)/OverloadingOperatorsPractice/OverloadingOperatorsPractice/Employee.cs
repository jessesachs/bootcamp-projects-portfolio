using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsPractice
{
    public class Employee
    {
        public int Id { get; set; } //declaring object properties
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static bool operator == (Employee employeeLeft, Employee employeeRight)
        {
            return (employeeLeft.Id == employeeRight.Id);
        }
        public static bool operator != (Employee employeeLeft, Employee employeeRight)
        {
            return (employeeLeft.Id != employeeRight.Id);
        }
    }
}
