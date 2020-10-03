using System;
using System.Collections.Generic;

namespace EmpWages
{
    public class Program
    {

        static void Main(string[] args)
        {
            Main capg = new Main();
            Main wip = new Main();
            capg.CalculateEmpWages("Capgemini", 20, 3, 20);
            
            wip.CalculateEmpWages("Wipro", 20, 4, 30);
          
        }



    }
}
   