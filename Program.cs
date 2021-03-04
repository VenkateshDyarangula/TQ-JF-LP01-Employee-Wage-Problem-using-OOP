using System;

namespace UC2_Emp_Wage_Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Full_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_Full_TIME)
                empHrs = 8;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage is:" + empWage);
            else
                empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Emp is Absent"+empWage);
            Console.ReadKey();
        }
    }
}

