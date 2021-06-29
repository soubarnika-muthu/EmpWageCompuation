using System;

namespace EmployeeWagecomputaion
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Creating object or Instance of random class
            Random random = new Random();
            //iNitializing variable
            int EMP_WAGE = 0;
            int EMP_PRESENT = 1;
            int EMP_INPUT = random.Next(0, 2);
            int FULL_TIME = 0;
            int WAGE_PER_HR = 20;
            //Using If condition checking whether employee is present or not 

            if (EMP_INPUT == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                FULL_TIME = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            ////Calculating Daily Wages of Employee
            EMP_WAGE = FULL_TIME * WAGE_PER_HR;
            Console.WriteLine("Daily Employee Wage is" + EMP_WAGE);
        }
    }
}