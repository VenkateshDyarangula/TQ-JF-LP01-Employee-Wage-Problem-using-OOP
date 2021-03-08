using System;

namespace UC6_Emp_Wage_HrDays_Reached_ForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constantsee
            const int IS_Full_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int Per_Month_Days = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            int Total_Working_Hrs = 100;
            for (int i = 0; i <= Total_Working_Hrs; i++)
            { 
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_Full_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }  
                    empWage = (empHrs * EMP_RATE_PER_HOUR) * Per_Month_Days;
                     Console.WriteLine("Emp Wage is :" + empWage);
            }
            
        }
    }
}

