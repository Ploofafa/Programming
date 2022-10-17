using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Содержит список всех покупателей.
        /// </summary>
        List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Хранит экземпляр класса <see cref="Customer"/> выбранного в ListBox.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Хранит переменную для подсказок пользователю в элементах.
        /// </summary>
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Метод для изменения информации в текстбоксах.
        /// </summary>
        private void ChangeCustomer()
        {
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IdCustomerTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName.ToString();
            AddressTextBox.Text = _currentCustomer.Address.ToString();
        }

        /// <summary>
        /// Обновляет название элемента в текстбокса.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer.FullName;
        }

        /// <summary>
        /// Метод для добавления элемента в листбокс.
        /// </summary>
        private void CustomerAdd()
        {
            Customer customer = new Customer();
            _currentCustomer = customer;
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add($"{_currentCustomer.FullName}");
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
            UpdateCustomerInfo();
        }

        /// <summary>
        /// Метод для удаления экземпляра списка из базы.
        /// </summary>
        private void CustomerRemove()
        {
            if (CustomersListBox.Items.Count > 0)
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
                if (CustomersListBox.Items.Count != 0)
                {
                    CustomersListBox.SelectedIndex = 0;
                }
                else
                {
                    CustomerClearInfo();
                }
            }
        }

        /// <summary>
        /// Метод для очищения всех полей ввода.
        /// </summary>
        private void CustomerClearInfo()
        {
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            IdCustomerTextBox.Clear();
        }

        public CustomerTab()
        {
            InitializeComponent();
        }

        private void AddCustomersButton_Click(object sender, EventArgs e)
        {
            CustomerAdd();
        }

        private void RemoveCustomersButton_Click(object sender, EventArgs e)
        {
            CustomerRemove();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                ChangeCustomer();
            }   
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) == false & _customers.Count != 0)
            {
                try
                {
                    _currentCustomer.FullName = Convert.ToString(FullNameTextBox.Text);
                    _toolTip.SetToolTip(FullNameTextBox, "");
                    FullNameTextBox.BackColor = AppColors.NormalColor;
                    UpdateCustomerInfo();
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(FullNameTextBox, exception.Message);
                    FullNameTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = Convert.ToString(AddressTextBox.Text);
                _toolTip.SetToolTip(AddressTextBox, "");
                AddressTextBox.BackColor = AppColors.NormalColor;
            }

            catch (Exception exception)
            {
                _toolTip.SetToolTip(AddressTextBox, exception.Message);
                AddressTextBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
