using System;

namespace EmployeeWagecomputaion
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Creating object or Instance of random class
            Random random = new Random();
            //Initializing variables
            int EMP_PRESENT = 1;
            int EMP_INPUT = random.Next(0, 2);
            //Using if condtion to check Employee attendance
            if (EMP_INPUT == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}