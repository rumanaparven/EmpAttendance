using System;

namespace EmpWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_part_time = 1;
            int is_full_time = 2;
            int rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == is_part_time)
            {
                empHrs = 4;
            }
            else if (check == is_full_time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * rate_per_hour;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
