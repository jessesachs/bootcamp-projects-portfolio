using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects4
{
    public class employee : person //person is a superclass of employee
    {
        public int id; //the int id property is specific to employee, and does not extend to the superclass person
    }
}
