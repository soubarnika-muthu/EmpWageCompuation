using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputaionUC
{
   public class EmpWageBuilder : IComputeEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public EmpWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(String COMPANY_NAME, int EMP_RATE_PER_HR, int NUM_OF_WORKINGDAYS, int MAX_HRS_PER_MONTH)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(COMPANY_NAME, EMP_RATE_PER_HR, NUM_OF_WORKINGDAYS, MAX_HRS_PER_MONTH);
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

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Initialize local variable
            int EMP_HRS = 0;
            int TOTAL_HRS = 0;
            int TOTAL_WORKINGDAYS = 0;


            //Using for loop to calculate wages for 20 days
            while (TOTAL_HRS <= companyEmpWage.MAX_HRS_PER_MONTH && TOTAL_WORKINGDAYS <= companyEmpWage.NUM_OF_WORKINGDAYS)
            {
                //Creating object or Instance of random class
                Random random = new Random();
                //Generating Random Value by Calling Next Method
                int EMP_INPUT = random.Next(0, 3);

                //Using switch case to check full time or part time employee
                switch (EMP_INPUT)
                {
                    case FULL_TIME:

                        EMP_HRS = 8;
                        break;
                    case PART_TIME:

                        EMP_HRS = 4;
                        break;
                    default:
                        EMP_HRS = 0;
                        break;
                }
                TOTAL_HRS += EMP_HRS;

                TOTAL_WORKINGDAYS++;


            }
            //Calculating Daily Wages of Employee
            return TOTAL_HRS * companyEmpWage.EMP_RATE_PER_HR;
        }

    }
}

