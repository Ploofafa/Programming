using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeDatabase.Classes;
using EmployeeDatabase.Panels;
using System.Collections;

namespace EmployeeDatabase.Panels
{

    /// <summary>
    /// Содержит логику пользовательского интерфейса <see cref="EmployeeDatabase"/>.
    /// Даёт возможности добавления, удаления, редактирования работников в БД.
    /// </summary>
    public partial class InputEmployeeControl : UserControl
    {

        /// <summary>
        /// Содержит информацию о выбранном работнике.
        /// </summary>
        private Employee _currentEmployee;
        
        /// <summary>
        /// Хранит список работников.
        /// </summary>
        private List<Employee> _employees = new List<Employee>()    ;

        /// <summary>
        /// Хранит переменную для подсказок пользователю в элементах.
        /// </summary>
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Метод сортировки листбокса по имени.
        /// </summary>
        private void SortListBox()
        {
            if (_employees.Count > 1)
            {
                EmployeesListBox.Items.Clear();
                _employees.Sort(delegate (Employee employee1, Employee employee2)
                {
                    return employee1.FullName.CompareTo(employee2.FullName);
                });
                EmployeesListBox.Items.AddRange(_employees.ToArray());
            }
            for(int i = 0; i < _employees.Count; i++)
            {
                EmployeesListBox.Items[i] = _employees[i].FullName;
            }
            EmployeesListBox.SelectedItem = _currentEmployee.FullName;
        }

        /// <summary>
        /// Добавляет нового работника в листбокс, список и заносит о нём информацию.
        /// </summary>
        /// <param name="employee">Содержит переменную с информацией о работнике.</param>
        private void EmployeeAddListBox()
        {
            CreateDefaultEmployee();
            _employees.Add(_currentEmployee);
            EmployeesListBox.Items.Add($"{_currentEmployee.FullName}");
            EmployeesListBox.SelectedIndex = _employees.Count - 1;
            UpdateEmployeeInfo();
        }

        /// <summary>
        /// Очищает все поля рабочего.
        /// </summary>
        private void EmployeeClearInfo()
        {
            FullNameTextBox.Clear();
            SalaryTextBox.Text = "0";
            JobTitleTextBox.Clear();
            EmployeeDateTimePicker.Value = DateTime.Today;
        }

        /// <summary>
        /// Обновляет информацию о текущем работнике.
        /// </summary>
        private void UpdateEmployeeInfo()
        {
            EmployeesListBox.Items[EmployeesListBox.SelectedIndex] = _currentEmployee.FullName;
        }

        /// <summary>
        /// Удаляет работника из системы. Если работников не осталось,
        /// то очищает все поля.
        /// </summary>
        private void EmployeesDelete()
        {
            if (EmployeesListBox.Items.Count != 0)
            {
                _employees.RemoveAt(EmployeesListBox.SelectedIndex);
                EmployeesListBox.Items.RemoveAt(EmployeesListBox.SelectedIndex);
                if (EmployeesListBox.Items.Count != 0)
                {
                    EmployeesListBox.SelectedIndex = 0;
                }
            }
            if (EmployeesListBox.Items.Count == 0)
            {
                EmployeeClearInfo();
            }
        }

        /// <summary>
        /// Создаёт работника по умолчанию
        /// </summary>
        private void CreateDefaultEmployee()
        {
            Employee employee = new Employee();
            employee.FullName = "New employee";
            employee.Salary = 18000;
            employee.JobTitle = "Trainee";
            employee.EmploymentDate = DateTime.Today;
            _currentEmployee = employee;
        }

        public InputEmployeeControl()
        {
            InitializeComponent();     
            
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeAddListBox();
        }

        private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedIndex != -1)
            {
                _currentEmployee = _employees[EmployeesListBox.SelectedIndex];
                FullNameTextBox.Text = _currentEmployee.FullName;
                SalaryTextBox.Text = _currentEmployee.Salary.ToString();
                JobTitleTextBox.Text = _currentEmployee.JobTitle;
                EmployeeDateTimePicker.Value = _currentEmployee.EmploymentDate;
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeesDelete();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) == false & _employees.Count != 0)
            {
                try
                {
                    _currentEmployee.FullName = Convert.ToString(FullNameTextBox.Text);   
                    _toolTip.SetToolTip(FullNameTextBox, "");
                    FullNameTextBox.BackColor = AppColors.NormalColor;
                    UpdateEmployeeInfo();
                    SortListBox();
                }

                catch (Exception exception)
                {
                    FullNameTextBox.BackColor = AppColors.ErrorColor;
                    _toolTip.SetToolTip(FullNameTextBox, exception.Message);
                }

            }
        }

        private void JobTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_employees.Count != 0)
            {
                try
                {
                    _currentEmployee.JobTitle = JobTitleTextBox.Text;
                    JobTitleTextBox.BackColor = AppColors.NormalColor;
                    _toolTip.SetToolTip(JobTitleTextBox, "");
                }

                catch (Exception exception)
                {
                    JobTitleTextBox.BackColor = AppColors.ErrorColor;
                    _toolTip.SetToolTip(JobTitleTextBox, exception.Message);
                }
            } 
        }

        private void EmployeeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _currentEmployee.EmploymentDate = EmployeeDateTimePicker.Value;
                _toolTip.SetToolTip(EmployeeDateTimePicker, "");
                EmployeeDateTimePicker.BackColor = AppColors.NormalColor;
            }

            catch (Exception exception)
            {
                EmployeeDateTimePicker.BackColor = AppColors.ErrorColor;
                _toolTip.SetToolTip(EmployeeDateTimePicker, exception.Message);
            }
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentEmployee.Salary = Int32.Parse(SalaryTextBox.Text);
                SalaryTextBox.BackColor = AppColors.NormalColor;
                _toolTip.SetToolTip(SalaryTextBox, "");
            }

            catch (Exception exception)
            {
                SalaryTextBox.BackColor = AppColors.ErrorColor;
                _toolTip.SetToolTip(SalaryTextBox, exception.Message);
            }
        }
    }
}
