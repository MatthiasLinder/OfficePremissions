using Ligipääsusüsteem_08._02._2018.Employee_Types;
using Ligipääsusüsteem_08._02._2018.Employee_Types.Developer_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem_08._02._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int Enter = 1;
            int ID = 0;
            while (Enter == 1)
            {
                Console.WriteLine("Please enter your ID.");
                Console.WriteLine("ID : 1 - Cleaner ; 2 - Developer ; 3 - Data Processor ; 4 - Supervisor");

                Console.WriteLine("");
                string ChooseEmployee = Console.ReadLine();
                Console.Clear();
                
                if (ChooseEmployee != null)
                {
                    ID = Int32.Parse(ChooseEmployee );
                }
                
                if (ID == 1)
                {
                    var CleanerType = new Cleaner();
                    Enter = CleanerType.BasicEntrance();
                }

                if (ID == 2)
                {
                    string DeveloperChoose = "0";
                    Console.WriteLine("Please choose your Developer type :");
                    Console.WriteLine("1 - Junior Developer");
                    Console.WriteLine("2 - Senior Developer");
                    DeveloperChoose = Console.ReadLine();
                    
                    if (DeveloperChoose == "1")
                    {
                        var DeveloperType = new JuniorDeveloper();
                        Enter = DeveloperType.BasicEntrance();
                    }
                    if(DeveloperChoose == "2")
                    {
                        var DeveloperType = new SeniorDeveloper();
                        Enter = DeveloperType.BasicEntrance();
                    }
                    else
                    {

                    }
                }

                if (ID == 3)
                {
                    var DataProcessorType = new DataProcessor();
                    Enter = DataProcessorType.BasicEntrance();
                }

                if (ID == 4)
                {
                    var SupervisorType = new Supervisor();
                    Enter = SupervisorType.BasicEntrance();
                }
                else
                {

                }
            }
            Console.ReadLine();
        }
    }
}
