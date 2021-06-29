using System;

namespace EmployeeWagecomputaion
{
    //UC3 ADDING PART TIME EMPLOYEE AND CALCULATE THE WAGES
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

            //Creating object or Instance of random class
            Random random = new Random();
            //Generating Random Value by Calling Next Method
            int EMP_INPUT = random.Next(0, 3);

            //Using Switch Statement to check Full time or Part time employee
            switch (EMP_INPUT)
            {
                case FULL_TIME:
                    Console.WriteLine("Full Time Employee");
                    EMP_HRS = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Part Time Employee");
                    EMP_HRS = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;


            }

            //Calculating Daily Wages of Employee
            EMP_WAGES = EMP_HRS * EMP_RATE_PER_HR;

            Console.WriteLine("Daily Wage for the employee is " + EMP_WAGES);
        }
    }
}