using System;
namespace EmpWageComputaionUC
{
    /// <summary>
    /// UC1- Finding out whether employee is present or absent
    /// UC2- Calculating the daily wages of the Employee
    /// UC3- Adding Part time employee and Calculate the Wages
    /// UC4- Calculating above UC using switch case
    /// UC5- Calculating Monthly Wages of Employee
    /// UC6- Calculating The wages till the condition of 100hr or for 20days
    /// UC7- Computing the Employee wages using class method
    /// UC8- Computing the employee wages for multiple company
    /// UC9- Saving total wages for each company using class EmployeeBuilder
    /// UC10-Manage multiple companies using array
    /// UC11-Creating API procedure
    /// UC12-Manage multiple companies using Array list
    /// UC13-Stores the daily wages of the employee
    /// </summary>
    /// <param name="args">The arguments.</param>
    /// 


    //class method to compute the employee wages
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            bool Continue = true;
            //creating object for each company
            EmpWageBuilder employeeWage = new EmpWageBuilder();

            while (Continue)
            {
                Console.WriteLine("Enter 1 to enter detail or 2 to display emp wage: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GetDetail(employeeWage);
                        break;
                    case 2:
                        Console.WriteLine("enter company name to get total wage:");
                        string name = Console.ReadLine();
                        Console.WriteLine(employeeWage.GetEmployeeWage(name));
                        break;
                    default:
                        Continue = false;
                        break;
                }
            }
            Console.Read();


            static void GetDetail(EmpWageBuilder employee)
            {
                Console.WriteLine("Enter company name:");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter Rate per Hr:");
                int rate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max working days:");
                int maxDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter max working hr:");
                int maxHr = Convert.ToInt32(Console.ReadLine());
                employee.addDetail(companyName, rate, maxDays, maxHr);
                employee.ComputeWage();
            }
        }
    }
}

