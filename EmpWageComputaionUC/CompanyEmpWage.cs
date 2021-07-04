using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputaionUC
{
    class CompanyEmpWage
    {
        public String COMPANY_NAME;
        public int EMP_RATE_PER_HR;
        public int NUM_OF_WORKINGDAYS;
        public int MAX_HRS_PER_MONTH;
        public int TOTAL_WAGES;
        //Constructor for EmpWageBuilderObject class; 
        public CompanyEmpWage(String COMPANY_NAME, int EMP_RATE_PER_HR, int NUM_OF_WORKINGDAYS, int MAX_HRS_PER_MONTH)
        {
            this.COMPANY_NAME = COMPANY_NAME;
            this.EMP_RATE_PER_HR = EMP_RATE_PER_HR;
            this.NUM_OF_WORKINGDAYS = NUM_OF_WORKINGDAYS;
            this.MAX_HRS_PER_MONTH = MAX_HRS_PER_MONTH;
        }
        public void setTotalEmpWage(int TOTAL_WAGES)
        {
            this.TOTAL_WAGES = TOTAL_WAGES;
        }
        public string toString()
        {
            return "Total Employee wage for Company " + this.COMPANY_NAME + " is " + this.TOTAL_WAGES;
        }
    }
}
