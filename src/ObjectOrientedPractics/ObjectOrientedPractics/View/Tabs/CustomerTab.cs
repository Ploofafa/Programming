﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику вкладки <see cref="CustomerTab"/>.
    /// </summary>
    partial class CustomerTab : UserControl
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
        /// Обновляет название элемента в текстбокса.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer.FullName;
        }

        /// <summary>
        /// Очищает все текстбоксы.
        /// </summary>
        private void CustomerClearInfo()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            addressControl1.ClearAddressInfo();
            DiscountsListBox.Items.Clear();
        }

        /// <summary>
        /// Обновляет всю информацию в текстбоксах.
        /// </summary>
        /// <param name="customer">Переменная покупателя, который возвращает данные.</param>
        private void UpdateAllTextBoxes(Customer customer)
        {
            IdTextBox.Text = customer.Id.ToString();
            NameTextBox.Text = customer.FullName.ToString();
            addressControl1.Address = customer.Address;
            addressControl1.UpdateAddress();
            IsPriorityCheckBox.Checked = customer.IsPriority;
        }

        /// <summary>
        /// Метод для добавления элемента в листбокс.
        /// </summary>
        private void CustomerAdd()
        {
            Customer customer = new Customer();
            _currentCustomer = customer;
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add($"{_currentCustomer.Address.City}");
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
            UpdateCustomerInfo();
            UpdateAllTextBoxes(customer);
        }

        /// <summary>
        /// Обновляет информацию в листбоксе.
        /// </summary>
        public void UpdateListBox()
        {
            if (_customers != null && _customers.Count > 0)
            {
                for (int i = 0; i < _customers.Count; i++)
                {
                    CustomersListBox.Items.Add(_customers[i].FullName);
                }
            }
        }

        /// <summary>
        /// Метод для удаления экземпляра списка из базы.
        /// </summary>
        private void CustomerRemove()
        {
            if (CustomersListBox.Items.Count > 0 & CustomersListBox.SelectedIndex != -1)
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
        /// Обновляет информацию о доступных скидках.
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();

            foreach(var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }

            set
            {
                _customers = value;
                
            }
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
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                UpdateAllTextBoxes(_customers[CustomersListBox.SelectedIndex]);
                UpdateDiscountsListBox();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) == false & _customers.Count != 0)
            {
                try
                {
                    _currentCustomer.FullName = Convert.ToString(NameTextBox.Text);
                    _toolTip.SetToolTip(NameTextBox, "");
                    NameTextBox.BackColor = AppColors.NormalColor;
                    UpdateCustomerInfo();
                }

                catch (Exception exception)
                {
                    NameTextBox.BackColor = AppColors.ErrorColor;
                    _toolTip.SetToolTip(NameTextBox, exception.Message);
                }
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                ChooseCategoryForm addDiscountForm = new ChooseCategoryForm();

                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    if (Convert.ToInt32(addDiscountForm.Category) == -1)
                    {
                        return;
                    }

                    foreach (var discount in _currentCustomer.Discounts)
                    {
                        if (discount is PointsDiscount)
                        {
                            continue;
                        }

                        if (((PercentDiscount)discount).Category ==
                            addDiscountForm.Category)
                        {
                            return;
                        }
                    }

                    _currentCustomer.Discounts.Add(new PercentDiscount(addDiscountForm.Category));
                    UpdateDiscountsListBox();
                }
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex != -1 && DiscountsListBox.SelectedIndex != 0)
            {
                _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                DiscountsListBox.Items.RemoveAt(DiscountsListBox.SelectedIndex);
                DiscountsListBox.SelectedIndex = 0;
            }
        }
    }
}
