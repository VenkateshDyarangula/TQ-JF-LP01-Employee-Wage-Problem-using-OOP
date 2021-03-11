using System;
using System.Collections.Generic;
using System.Text;

namespace UC8_Emp_Wage_Multiple_Companies
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            UC8_Program program = new UC8_Program();
            program.computeEmpWage("DMart", 20, 2, 10);
            program.computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
