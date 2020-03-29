using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace EmployeeCalculator
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            //BinaryFormatter binary = null;
            XmlSerializer xs = null;
            List<Employee> eList = null;
            try
            {
                if (File.Exists(@"C:\Users\Administrator\Documents\Visual Studio 2013\Projects\Assignments Varsha\serialization\EmployeeCalculator\bin\Debug\list.xml"))
                {
                    FileStream fs = new FileStream(@"C:\Users\Administrator\Documents\Visual Studio 2013\Projects\Assignments Varsha\serialization\EmployeeCalculator\bin\Debug\list.xml", FileMode.Open);
                //    binary = new BinaryFormatter();
                    xs = new XmlSerializer(typeof(List<Employee>),new Type[]{ typeof(Employee),typeof(HR),typeof(Developer)});
                    eList = (List<Employee>)xs.Deserialize(fs);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Not possible");
            }
            EmployeeData.DataSource = eList;
        }
    }
}
