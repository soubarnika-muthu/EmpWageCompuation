using System;
//UC9 CALCULATING WAGES FOR  A TOTAL WORKING DAYS AND HOURS IS REACHED FOR A MONTH
namespace EmployeeWagecomputaion
{
    //Adding constant global variable


    public class EmpWageBuilderObject
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private String COMPANY_NAME;
        private int EMP_RATE_PER_HR;
        private int NUM_OF_WORKINGDAYS;
        private int MAX_HRS_PER_MONTH;
        private int TOTAL_WAGES;
        //Constructor for EmpWageBuilderObject class; 
        public EmpWageBuilderObject(String COMPANY_NAME, int EMP_RATE_PER_HR, int NUM_OF_WORKINGDAYS, int MAX_HRS_PER_MONTH)
        {
           this.COMPANY_NAME= COMPANY_NAME;
           this.EMP_RATE_PER_HR= EMP_RATE_PER_HR;
           this.NUM_OF_WORKINGDAYS = NUM_OF_WORKINGDAYS;
           this.MAX_HRS_PER_MONTH= MAX_HRS_PER_MONTH;
        }
        public void ComputeEmpWage()
        {
            //Initialize local variable
            int EMP_HRS = 0;
            int TOTAL_HRS = 0;
            int TOTAL_WORKINGDAYS = 0;
            //Creating object or Instance of random class
            Random random = new Random();

            //Using for loop to calculate wages for 20 days
            while (TOTAL_HRS <= MAX_HRS_PER_MONTH && TOTAL_WORKINGDAYS <= NUM_OF_WORKINGDAYS)
            {
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
            TOTAL_WAGES = TOTAL_HRS * EMP_RATE_PER_HR;
            Console.WriteLine("Total Employee wage for Company " + COMPANY_NAME + " is " + TOTAL_WAGES);
         
        }
        // A fuction that prints employee wage
           public string toString()
           {
            return "Total Employee wage for Company " + this.COMPANY_NAME + " is " + this.TOTAL_WAGES;
           }
    }

        class Program
        {
           static void Main(String[] args)
           {
                EmpWageBuilderObject tvs = new EmpWageBuilderObject("TVSNEXT", 20, 10, 10);
                tvs.ComputeEmpWage();
                Console.WriteLine(tvs.toString());
                EmpWageBuilderObject hcl = new EmpWageBuilderObject("HCL", 20, 10, 10);
                hcl.ComputeEmpWage();
                Console.WriteLine(hcl.toString());
           }
        }
        
        

       
       
}

