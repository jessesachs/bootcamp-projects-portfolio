using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    public class ExtraClass
    {
        public int FavoriteMethod(int userInput1, int userInput2 = 0)
        {
            //this method adds userInput1 and userinput2, integer parameters that get passed in from main class
            return userInput1 + userInput2; //then returns the sum of parameters
        }
    }
}
