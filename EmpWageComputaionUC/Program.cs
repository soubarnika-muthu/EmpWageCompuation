using System;

namespace EmployeeWagecomputaion
{

    //UC5 CALCULATING WAGES FOR  A MONTH
    class Program
    {
        //Adding constant global variable
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int EMP_RATE_PER_HR = 20;

        static void Main(string[] args)
        {
            //Initialize local variable
            int EMP_HRS = 0;
            int EMP_WAGES;
            int DAY;
            int WORKING_DAYS = 20;
            int TOTAL_WAGES = 0;

            //Creating object or Instance of random class
            Random random = new Random();

            //Using for loop to calculate wages for 20 days
            for (DAY = 1; DAY <= WORKING_DAYS; DAY++)
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
            }

            //Calculating Daily Wages of Employee
            EMP_WAGES = EMP_HRS * EMP_RATE_PER_HR;
            TOTAL_WAGES += EMP_WAGES;

            Console.WriteLine("Employee wage for " + WORKING_DAYS + " day is " + TOTAL_WAGES);
        }
    }
}
