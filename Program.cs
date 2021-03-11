#UC1
using System;

namespace UC1_Emp_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Full_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_Full_TIME)
                Console.WriteLine("Emp is Present");
            else
                Console.WriteLine("Emp is Absent");
            Console.ReadKey();
        }
    }
}


#UC2
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

#UC3

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

#UC4

using System;

namespace UC4_SolvingUsing_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            const int IS_Full_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage is :" + empWage);
        }
    }
}


#UC5

using System;

namespace UC5_Emp_WageForMonth_20Days
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
             const int IS_PART_TIME = 1;
             const int IS_FULL_TIME = 2;
             const int EMP_RATE_PER_HOUR = 20;
             const int NUM_OF_WORKING_DAYS = 20;
           //variables
           int empHrs = 0;
           int empWage = 0;
           int totalEmpWage = 0;
           for(int day = 0; day<NUM_OF_WORKING_DAYS; day++)
            {
 
             Random random = new Random();
             int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs* EMP_RATE_PER_HOUR;
            totalEmpWage += empWage;
            Console.WriteLine("Emp Wage: " + empWage);
            }
              Console.WriteLine("Total Emp Wage: " + totalEmpWage); 
        }
    }
}

#UC6

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
