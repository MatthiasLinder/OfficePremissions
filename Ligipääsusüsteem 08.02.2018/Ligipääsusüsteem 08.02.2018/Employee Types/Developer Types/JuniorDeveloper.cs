using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018.Employee_Types.Developer_Types
{
    class JuniorDeveloper : Developer
    {
        public JuniorDeveloper()
        {
            EmployeeType = "Junior Developer";
            SecurityClearance = 1;
        }

        public override int BasicEntrance()
        {
            Console.WriteLine("You have Junior developer type Clearance.");
            Console.WriteLine("You can only access the Kitchen and the Developer's Station.");
            Console.WriteLine("");
            return base.BasicEntrance();
        }

    }
}
