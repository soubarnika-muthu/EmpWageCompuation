using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputaionUC
{
    class EmployeeDetails
    {
        //global variables
        public string companyName;
        public int employeeRatePerHr;
        public int maxWorkingDays;
        public int maxWorkingHrs;
        public int totalWages;
        private LinkedList<int> dailywage;

        //Assign the values passed during object creation to current variables
        public EmployeeDetails(string companyName, int employeeRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.employeeRatePerHr = employeeRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            dailywage = new LinkedList<int>();
        }

        public void SetEmployeeWage(int wage)
        {
            this.totalWages = wage;
        }

        //set the daily wages for the employee
        public void SetDailyWage(int wage, EmployeeDetails employee)
        {
            employee.dailywage.AddLast(wage);
        }

        public string toString()
        {
            return "Total Employee wage for company \"" + this.companyName + "\" is :" + this.totalWages;
        }

        //display the daily wages for the employee 
        public void DisplayDailyWage(EmployeeDetails employee)
        {
            int day = 1;
            foreach (int wage in employee.dailywage)
            {
                Console.WriteLine("Day{0}:{1}", day, wage);
                day++;
            }
        }

    }
}