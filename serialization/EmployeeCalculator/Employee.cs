using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCalculator
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int Basic { get; set; }

        public int Da { get; set; }

        public int Hra { get; set; }

        public int Total { get; set; }

        public virtual void CalculateSalary()
        {
            Total = Basic + Da + Hra;
        }
    }
}
