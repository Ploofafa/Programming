using EmployeeDatabase.Classes;
using Newtonsoft.Json;
using System.Windows.Forms.Design;
using EmployeeDatabase.Panels;

namespace EmployeeDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {   
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectSerializer.SaveEmployeesToFile(inputEmployeeControl.Employees);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees.AddRange(ProjectSerializer.LoadEmployeesToFile());
            inputEmployeeControl.Employees = employees;
            for (int i = 0; i < inputEmployeeControl.Employees.Count; i++)
            {
                inputEmployeeControl.EmployeesListBox.Items.Add(inputEmployeeControl.Employees[i].FullName);
            }
        }
    }
}