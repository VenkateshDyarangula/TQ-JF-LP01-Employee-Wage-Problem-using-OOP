using System;
using System.Collections.Generic;
using System.Text;

namespace UC12_ArrayList_EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.computeEmpWage();
        }
    }
}
