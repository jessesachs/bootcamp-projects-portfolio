using System;

namespace CodeFirstStudentsConsole
{
    class Program
    {
        public static void Main(string[] args)
        {


            using (SchoolContextConsole ctx = new SchoolContextConsole())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);

                foreach (var student in ctx.Students)
                {
                    Console.WriteLine(student.StudentName);
                }


                ctx.SaveChanges();
            }



            Console.ReadLine();
        }
    }
}