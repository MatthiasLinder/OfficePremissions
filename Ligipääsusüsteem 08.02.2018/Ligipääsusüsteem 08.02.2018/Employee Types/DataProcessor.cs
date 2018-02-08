using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018.Employee_Types
{
    class DataProcessor : Employee
    {
        public DataProcessor()
        {
            EmployeeType = "Data Processor";
            SecurityClearance = 3;
        }
        public override int BasicEntrance()
        {
            Console.WriteLine("You have Data Processor type Clearance.");
            Console.WriteLine("You can only access the Data Processor Station and the Kitchen.");
            Console.WriteLine("");
            return base.BasicEntrance();
        }
    }
}
