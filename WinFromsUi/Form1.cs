using ProjectCoreLibrary.Controllers;
using ProjectCoreLibrary.DataAccess;
using ProjectCoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromsUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeModel emp = new EmployeeModel()
            {
                BirthDate = new DateTime(1998, 4, 8),
                Name = "asdasda"
            };


            IDataAccess<IEmployeeModel> dataAccess = new FileDataAccess<IEmployeeModel>();
            EmployeeController employeeController = new EmployeeController(dataAccess);

            employeeController.SaveEmployee(emp);
            employeeController.LoadEmployee();
            foreach (var item in employeeController.LoadEmployee())
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
