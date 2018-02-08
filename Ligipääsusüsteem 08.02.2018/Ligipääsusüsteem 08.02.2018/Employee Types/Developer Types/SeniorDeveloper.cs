using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018.Employee_Types.Developer_Types
{
    class SeniorDeveloper : Developer
    {
        public SeniorDeveloper()
        {
            EmployeeType = "Senior Developer";
            SecurityClearance = 2;
        }

        public override int BasicEntrance()
        {
            Console.WriteLine("You have Senior developer type Clearance.");
            Console.WriteLine("You can access any room in the building.");
            Console.WriteLine("");
            return base.BasicEntrance();
        }
    }
}
