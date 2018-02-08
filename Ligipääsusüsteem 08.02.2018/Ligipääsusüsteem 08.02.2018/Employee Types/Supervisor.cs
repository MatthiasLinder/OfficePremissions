using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018.Employee_Types
{
    class Supervisor : Employee
    {
        public Supervisor()
        {
            EmployeeType = "Supervisor";
            SecurityClearance = 5;
        }
        public override int BasicEntrance()
        {
            Console.WriteLine("You have Supervisor type Clearance.");
            Console.WriteLine("You can enter any room in the building.");
            Console.WriteLine("");
            return base.BasicEntrance();
        }
    }
}
