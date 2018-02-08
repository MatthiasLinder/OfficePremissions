using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018.Employee_Types
{
    class Cleaner : Employee
    {
        public Cleaner()
        {
            EmployeeType = "Cleaner";
            SecurityClearance = 4;
        }

        public override int BasicEntrance()
        {
            Console.WriteLine("You have Cleaner type Security access.");
            Console.WriteLine("You can enter any room in the building.");
            Console.WriteLine("");
            return base.BasicEntrance();
        }
    }
}
