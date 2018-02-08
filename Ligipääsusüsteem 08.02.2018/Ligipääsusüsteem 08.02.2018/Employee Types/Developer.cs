using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018.Employee_Types
{
    class Developer : Employee
    {
        public Developer()
        {
            EmployeeType = "Developer";
            SecurityClearance = 1;
        }
        
    }
}
