using System;

namespace EmpWages
{
    class Program
    {

        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int rate_per_hour = 20;
        public const int num_of_working_days = 20;
        public const int max_working_hrs_in_month = 100;
        public static void CalculateEmpWages()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= max_working_hrs_in_month && totalWorkingDays < num_of_working_days)
            {

                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case is_part_time:
                        empHrs = 4;
                        break;
                    case is_full_time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * rate_per_hour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        
        }
        static void Main(string[] args)
        {
            CalculateEmpWages();
        }
    }
}
