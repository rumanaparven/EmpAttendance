using System;

namespace EmpWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_full_time = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == is_full_time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
