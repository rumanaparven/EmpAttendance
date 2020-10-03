using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EmpWages
{
    public class Program
    {

        static void Main(string[] args)
        {
            int choice = 0;
            Dictionary<String, ComputeEmpWage> d = new Dictionary<string, ComputeEmpWage>();
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Enter Company Details.");
                Console.WriteLine("2.View Company Details.");
                Console.WriteLine("3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                Main m = new Main();
                if (choice == 1)
                {
                    Console.WriteLine("Enter the name of the company :");
                    String cname = Console.ReadLine();
                    Console.WriteLine("Enter the employee rate per hour :");
                    int rate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the maximum number of working days :");
                    int wdays = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the maximum working hour in a month :");
                    int whour = Convert.ToInt32(Console.ReadLine());
                    ComputeEmpWage empWage = m.CalculateEmpWages(cname, rate, wdays, whour);
                    d.Add(cname, empWage);
                    
                }
                else if (choice == 2)
                {
                    Boolean flag = false;
                    Console.WriteLine("Enter the name of the company :");
                    String cname = Console.ReadLine();
                    foreach(KeyValuePair< String, ComputeEmpWage> kvp in d)
                    {
                        if (kvp.Key == cname)
                        {
                            flag = true;
                            Console.WriteLine("The total Employee Wage of " + kvp.Value.GetCompany() + " is : " + kvp.Value.GetTotalEmpWage());
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Could not find any entries for this Company.");
                        }
                        Console.WriteLine();
                    }


                }
            } while (choice != 3);
          
        }



    }
}
   