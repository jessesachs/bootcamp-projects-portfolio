using System;

namespace LambdaFunctionAssignment
{
    class myClass
    {
        public static void Main(string[] args)
        {
            //below I declare 10 instances of class employee

            Employee employee0 = new Employee();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();
            Employee employee7 = new Employee();
            Employee employee8 = new Employee();
            Employee employee9 = new Employee();

            //below I assign a first name, last name, and ID to all 10 classes
            employee0.fName = "Joe";
            employee0.lName = "Arrow";
            employee0.Id = 0;

            employee1.fName = "Maisy";
            employee1.lName = "Mouse";
            employee1.Id = 1;

            employee2.fName = "Winney";
            employee2.lName = "ThePoo";
            employee2.Id = 2;

            employee3.fName = "Roger";
            employee3.lName = "that";
            employee3.Id = 3;

            employee4.fName = "Babe";
            employee4.lName = "Ruth";
            employee4.Id = 4;

            employee5.fName = "Start";
            employee5.lName = "Stop";
            employee5.Id = 5;

            employee6.fName = "Laurie";
            employee6.lName = "Lumber";
            employee6.Id = 6;

            employee7.fName = "Joe";
            employee7.lName = "Star";
            employee7.Id = 7;

            employee8.fName = "Missy";
            employee8.lName = "Cats";
            employee8.Id = 8;

            employee9.fName = "Silly";
            employee9.lName = "Names";
            employee9.Id = 9;

            //below I add all ten employee objects to a List

            List<Employee> employeesList = new List<Employee>()
            {
                employee0 , employee1 , employee2 , employee3 , employee4 , employee5 , employee6 , employee7 , employee8 , employee9
            };

            //below I create a separate list dedited to employee objects with first name variable of 'Joe' (string)

            List<Employee> employeesNamedJoe = new List<Employee>();

            //below I loop through all employees in employeesList.  if the first name is 'Joe', the entire object gets added into employeesNamedJoe list

            foreach (Employee employee in employeesList)
            {
                if (employee.fName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }

            //here, we do the same thing that we just did above (creating a seperate list for Joe's), but we do so with Lambda expressions

            List<Employee> LambdaEmployeesNamedJoe = employeesList.Where(x => x.fName == "Joe").ToList();

            //here, we use Lambda expressions to create a list of employee objects where the ID is greater than 5
            List<Employee> IDOverFive = employeesList.Where(x => (x.Id > 5)).ToList();

            //the following two foreach loops test whether the above lambda functions work

            foreach (Employee employee in LambdaEmployeesNamedJoe)
            {
                Console.WriteLine(employee.fName);
            }
            foreach (Employee employee in IDOverFive)
            {
                Console.WriteLine(employee.Id);
            }

            //end of program
            Console.ReadLine();
        }
    }
}