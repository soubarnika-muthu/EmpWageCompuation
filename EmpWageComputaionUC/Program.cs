using System;
namespace EmployeeWagecomputaion
{

    public class EmpWageBuilderArray
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public EmpWageBuilderArray()
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

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
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
    public class CompanyEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

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







    class Program
        {
           static void Main(String[] args)
           {
                EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                empWageBuilder.addCompanyEmpWage("TVSNEXT", 20, 10, 10);
                empWageBuilder.addCompanyEmpWage("HCL", 20, 10, 10);
                empWageBuilder.computeEmpWage();
           }
        }
        
        

       
       
}

