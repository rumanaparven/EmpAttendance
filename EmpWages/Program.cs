using System;

namespace EmpWages
{
    class Program
    {

        public const int is_part_time = 1;
        public const int is_full_time = 2;
        
        public static void CalculateEmpWages(String CompanyName, int EmpRatePerHour, int MaxNumberOfWrkinDays, int MaxHrPerMonth)
        {
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= MaxHrPerMonth && totalWorkingDays < MaxNumberOfWrkinDays)
            {
                int empHrs = 0;
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
         
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Emp Wage of "+CompanyName+" is : " + totalEmpWage);
        
        }
        static void Main(string[] args)
        {
            CalculateEmpWages("Capgemini",20,3,20);
            CalculateEmpWages("Wipro", 20, 4, 30);
        }
    }
}
