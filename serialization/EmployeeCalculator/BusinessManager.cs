using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

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

        public static void SerializeMethod()
        {
            FileStream stream = new FileStream("list.xml", FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            XmlSerializer xs = null;
            xs = new XmlSerializer(typeof(List<Employee>), new Type[] { typeof(Employee), typeof(HR), typeof(Developer) });
            xs.Serialize(stream, empList);
        }
    }
}
