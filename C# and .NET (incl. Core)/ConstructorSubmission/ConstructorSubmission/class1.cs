using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class class1
    {
        public class1(string username) :this(username, "Hello") //this constructor is chained to the one below it.  "hello" is the default message if none gets passed through upon instantiation of class1 object
        {
        }
        public class1 (string username, string message) //other constructor
        {
            Console.WriteLine(username + " " + message); //says hi to string username

        }


    }
}
