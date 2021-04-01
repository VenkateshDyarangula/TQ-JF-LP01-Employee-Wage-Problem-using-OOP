using System;

namespace UC9_Save_TotalWage_forEach_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            EmpWageBuilder dmart = new EmpWageBuilder("Dmart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());

        }
    }
}
