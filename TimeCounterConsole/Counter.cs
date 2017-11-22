using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCounterConsole
{
    public  class Counter
    {

        public  int Tasks { get; set; }
        public  int Time { get; set; }

        public void CountingTime(List<int> Employees)
         {
             List<int> emp = new List<int>();
             
            for (int i = 0; i < Employees.Count; i++)
             {
                 emp.Add(Employees[i]);
             }           

             while (Tasks != 0)
             {                   
                 for (int i = 0; i < emp.Count && Tasks != 0; i++)
                 {                                         
                     emp[i]--;                   

                     if (emp[i] == 0)
                     {
                         Tasks--;
                         
                         if (Tasks > 1)
                         {
                             emp[i] = Employees[i];
                         }
                         else{}
                     }
                     else { }                    
                 }

                 Time++;               
             }

             for (int i = 0; i < emp.Count; i++)
             {
                 if (emp[i] > 0)
                 {
                     Time += emp[i]; 
                 }                 
             }

         }

    }
}
