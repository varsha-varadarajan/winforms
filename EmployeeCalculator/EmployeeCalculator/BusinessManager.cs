using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCalculator
{
    public static class BusinessManager
    {
        static List<Employee> empList = new List<Employee>();

        public static List<Employee> EmpList
        {
            get { return BusinessManager.empList; }
            //set { BusinessManager.empList = value; }
        }

        public static void AddEmployeeIntoList(Employee e)
        {
            empList.Add(e);
        }
    }
}
