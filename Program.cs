using System;

namespace UC3_Part_Full_Time_Emp_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Full_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_Full_TIME)
                empHrs = 8;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage is :" + empWage);
            Console.ReadKey();
            else if (empCheck ==0)
                Console.WriteLine("Emp is Absent!");
            Console.ReadKey();
        }
    }
}

