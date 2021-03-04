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
