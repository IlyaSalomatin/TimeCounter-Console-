using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCounterConsole
{
    public class Menu
    {
        public void StartProject()
        {
            Counter FirstCounter = new Counter();
            List<int> Employees = new List<int>();
         
            while (true)
            {

                Console.Clear();
                Console.WriteLine("<<TASKS EXECUTION TIME>>");
                Console.WriteLine();
                Console.WriteLine("COMMANDS:");
                Console.WriteLine("Write down the number of tasks : t;");
                Console.WriteLine("Add employee : <+>;");
                Console.WriteLine("Remove last employee : <->;");                
                Console.WriteLine("Calculate the time : c;");
                Console.WriteLine("Remove all : k;"); 
                Console.WriteLine("Press (X) to exit.");
                Console.WriteLine();

                if (FirstCounter.Tasks != 0)
                {
                    Console.WriteLine("Your number of tasks - " + FirstCounter.Tasks + ".");
                }

                if (Employees.Count > 0)
                {
                    for (int i = 0; i < Employees.Count; i++)
                    {
                        Console.WriteLine("employee" + (i + 1) + ": one task = " + Employees[i] + "min;"); 
                    }
                }
                Console.WriteLine();

                Console.Write("Please enter the command -  ");
                string command = Console.ReadLine();
                command.ToLower();
                switch (command)
                {
                    case "t":
                        {
                            if (FirstCounter.Tasks == 0)
                            {
                                Console.Write("Please enter the number of tasks -  ");
                                try
                                {
                                    int tasks = int.Parse(Console.ReadLine());
                                    if (tasks > 0)
                                    {
                                        FirstCounter.Tasks = tasks;
                                    }
                                    else
                                    {
                                        Console.Write("Enter a POSITIVE integer!!!");
                                        Console.ReadLine();
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Enter an INTEGER!!!");
                                }                                
                            }
                            else
                            {
                                Console.Write("!!!Command not available!!!");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case "+":
                        {
                            Console.Write("Please enter the speed of work at minutes -  ");
                            try
                            {
                                int speed = int.Parse(Console.ReadLine());
                                if (speed > 0)
                                {
                                    Employees.Add(speed);
                                }
                                else
                                {
                                    Console.Write("Enter a POSITIVE integer!!!");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception)
                            {
                                Console.Write("Enter an INTEGER!!!");
                            }
                        }
                        break;

                    case "-":
                        {
                            if (Employees.Count != 0)
                            {
                                Employees.RemoveAt(Employees.Count-1);
                            }
                            else
                            {
                                Console.Write("!!!Command not available!!!");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case "c":
                        {
                            if (Employees.Count!= 0 && FirstCounter.Tasks!= 0)
                            {
                                FirstCounter.CountingTime(Employees);
                                Console.Write("To complete all tasks, the team will spend - " + FirstCounter.Time + " minutes.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Write("!!!Insufficient DATA!!!");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case "k":
                        {
                            FirstCounter = new Counter();
                            Employees = new List<int>();
                        }
                        break;

                    case "x":
                        return;

                    default:
                        Console.Write("<<Incorrect command, press Enter-please>>");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
