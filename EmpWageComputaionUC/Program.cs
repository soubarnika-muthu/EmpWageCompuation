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
    /// UC11-Creating API procedure
    /// UC12-Manage multiple companies using Array list
    /// UC13-Stores the daily wages of the employee
    /// </summary>
    /// <param name="args">The arguments.</param>
    /// 


    //class method to compute the employee wages
    public class Program
        {
           static void Main(String[] args)
           {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //creating object for each company
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("TVSNEXT", 20, 10, 10);
                empWageBuilder.addCompanyEmpWage("HCL", 20, 10, 10);
                empWageBuilder.computeEmpWage();
           }
        }
        
        

       
       
}

