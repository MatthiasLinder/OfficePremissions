using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018
{
    class Employee
    {
        protected string EmployeeType;
        protected int SecurityClearance;

        public virtual int BasicEntrance()
        {
            int LoopControl = 0;
            while(LoopControl == 0)
            {
                string Action = "0";
                Console.WriteLine("Welcome " + EmployeeType);
                Console.WriteLine("Thank you for coming into work.");
                Console.WriteLine("Which room do you want to enter?");
                Console.WriteLine("1. Kitchen");
                Console.WriteLine("2. Developer's Station");
                Console.WriteLine("3. Data Processor's Station");
                Console.WriteLine("4. Supervisor's Office");
                Action = Console.ReadLine();
                //KITCHEN
                if (Action == "1")
                {
                    if (SecurityClearance > 0)
                    {
                        Console.WriteLine("Yup");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Nope");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                //DEVELOPER STATION
                if (Action == "2")
                {
                    if (SecurityClearance == 1 || SecurityClearance == 2 || SecurityClearance == 4 || SecurityClearance == 5)
                    {
                        Console.WriteLine("Yup");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Nope");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                //DATA PROCESSOR STATION
                if (Action == "3")
                {
                    if (SecurityClearance == 3 || SecurityClearance == 4 || SecurityClearance == 5 || SecurityClearance == 2)
                    {
                        Console.WriteLine("Yup");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Nope");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                //SUPERVISOR'S OFFICE
                if (Action == "4")
                {
                    if (SecurityClearance == 5 || SecurityClearance == 4 || SecurityClearance == 2)
                    {
                        Console.WriteLine("Yup");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Nope");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                }
            }
            return 1;
        }
    }
}
