using System;
using System.Collections.Generic;
using System.Text;
using static UC14_getTotalWageByCompany.CompanyEmpWage;

namespace UC14_getTotalWageByCompany
{
    public class EmpWageBuilder : IEmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int numOfCompany = 0;
        List<CompanyEmpWage> companyEmpWageArray = new List<CompanyEmpWage>();
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray.Add(new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth));
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp hrs " + empHrs + "  Daily Wage:" + (empHrs * companyEmpWage.empRatePerHour));
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}
