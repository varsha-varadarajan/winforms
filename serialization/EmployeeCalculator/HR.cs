using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCalculator
{
    [Serializable]
    public class HR : Employee
    {
        public int Gratuity { get; set; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            Total = Total + Gratuity;
        }
    }
}
