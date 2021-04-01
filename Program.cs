using System;

namespace UC11_Interface_Approach
{
    class Program
    {
            public static void Main(string[] args)
            {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.computeEmpWage();
            }
        
    }
}
