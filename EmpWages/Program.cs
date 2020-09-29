using System;

namespace EmpWages
{
    class Program
    {

      
        
       
        static void Main(string[] args)
        {
            Employee capg = new Employee("Capgemini", 20, 3, 20);
            Employee wip = new Employee("Wipro", 20, 4, 30);
            capg.CalculateEmpWages();
            capg.ToString();
            wip.CalculateEmpWages();
            wip.ToString();
        }
    }
    public class Employee
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;

        private String CompanyName;
        private int EmpRatePerHour;
        private int MaxNumberOfWrkinDays;
        private int MaxHrPerMonth;
        private int totalEmpWage;
        
       
        public void ToString()
        {
            Console.WriteLine("Total Emp Wage of " + this.CompanyName + " is : " + this.totalEmpWage);
        }

        public Employee(String CompanyName, int EmpRatePerHour, int MaxNumberOfWrkinDays, int MaxHrPerMonth)
        {
            this.CompanyName = CompanyName;
            this.EmpRatePerHour = EmpRatePerHour;
            this.MaxNumberOfWrkinDays = MaxNumberOfWrkinDays;
            this.MaxHrPerMonth = MaxHrPerMonth;
        }
        public  void CalculateEmpWages()
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
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * EmpRatePerHour;
        

        }

    }
}
