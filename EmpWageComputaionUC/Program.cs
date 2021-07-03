using System;

namespace EmployeeWagecomputaion
{

    //UC6 CALCULATING WAGES FOR  A TOTAL WORKING DAYS AND HOURS IS REACHED FOR A MONTH
    class Program
    {
        //Adding constant global variable
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        

        public static int ComputeEmpWage(String COMPANY_NAME,int EMP_RATE_PER_HR, int NUM_OF_WORKINGDAYS,int MAX_HRS_PER_MONTH )
        {
          //Initialize local variable
            int EMP_HRS = 0;
            int TOTAL_HRS = 0;
            int TOTAL_WORKINGDAYS = 0;

           
           
            int TOTAL_WAGES = 0;

            //Creating object or Instance of random class
            Random random = new Random();

            //Using for loop to calculate wages for 20 days
            while (TOTAL_HRS <=MAX_HRS_PER_MONTH  && TOTAL_WORKINGDAYS <=NUM_OF_WORKINGDAYS)
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
            return TOTAL_WAGES;
        }
        static void Main(String[] args)
        {
            ComputeEmpWage("TVSNEXT",20,10,10);
            ComputeEmpWage("HCL", 20, 10, 10);
            ComputeEmpWage("TCS", 20, 10, 10);

        }
    }
}
