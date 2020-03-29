using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCalculator
{
    [Serializable]
    public class Developer: Employee
    {
        public int Incentive { get; set; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            Total = Total + Incentive;
        }
    }
}
