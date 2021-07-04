using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputaionUC
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string companyName, int employeeRatePerHr, int maxWorkingDays, int maxWorkingHrs);
        public void computeEmpWage();

    }
}
