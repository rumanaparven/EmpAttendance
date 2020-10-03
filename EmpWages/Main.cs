using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    public class Main: IComputeEmpwage
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;

        public void CalculateEmpWages(String CompanyName, int EmpRatePerHour, int MaxNumberOfWrkinDays, int MaxHrPerMonth)
        {
            List<ComputeEmpWage> list = new List<ComputeEmpWage>();
           
            ComputeEmpWage ce = new ComputeEmpWage(CompanyName, EmpRatePerHour, MaxNumberOfWrkinDays, MaxHrPerMonth);
            list.Add(ce);
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            Console.WriteLine(CompanyName + " ");
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
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }

            int TotalEmpWage = totalEmpHrs * EmpRatePerHour;
            ce.SetTotalEmpWage(TotalEmpWage);
            Console.WriteLine(ce.ToString());
            
        }
        


    }

}

