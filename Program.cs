using System;

namespace UC14_getTotalWageByCompany
{
    class Program
    {     //  Console.WriteLine("Hello World!");
            static void Main(string[] args)
            {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.computeEmpWage();
            }
       
    }
}
