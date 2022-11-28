using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();

        private List<Item> _currentCustomerItems = new List<Item>();

        private List<Customer> _customers = new List<Customer>();

        private Customer _currentCustomer;


        /// <summary>
        /// Метод для обновления данных на вкладке.
        /// </summary>
        public void RefreshData()
        {
            CartListBox.Items.Clear();
            ItemsListBox.Items.Clear();
            CustomerComboBox.Items.Clear();
            UpdateListBox();
            UpdateComboBox();
            CustomerComboBox.SelectedIndex = -1;
            CustomerComboBox.Text = "";
            NumberLabel.Text = "0";
        }

        /// <summary>
        /// Заполняет лист бокс имеющимися данными.
        /// </summary>
        public void UpdateListBox()
        {
            if (_items.Count > 0)
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    ItemsListBox.Items.Add(_items[i].Name);
                }
            }
        }

        /// <summary>
        /// Заполняет комбо бокс имеющимися данными.
        /// </summary>
        public void UpdateComboBox()
        {
            if (_customers.Count > 0)
            {
                for (int i = 0; i < _customers.Count; i++)
                {
                    CustomerComboBox.Items.Add(_customers[i].FullName);
                }
            }
        }

        /// <summary>
        /// Метод добавления товара в корзину.
        /// </summary>
        private void AddItemToCart()
        {
            if (_currentCustomer != null && ItemsListBox.SelectedIndex != -1)
            {
                CartListBox.Items.Add(ItemsListBox.SelectedItem);
                _currentCustomerItems.Add(_items[ItemsListBox.SelectedIndex]);
                _currentCustomer.Cart.Items = _currentCustomerItems;
                UpdateAmount();
            }
        }

        /// <summary>
        /// Метод который заполняет корзину товарами выбранными другим пользователем.
        /// </summary>
        private void ChangeCustomer()
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customers[CustomerComboBox.SelectedIndex];
                _currentCustomerItems = _currentCustomer.Cart.Items;
                CartListBox.Items.Clear();
                if (_currentCustomerItems.Count > 0)
                {
                    for (int i = 0; i < _currentCustomerItems.Count; i++)
                    {
                        CartListBox.Items.Add(_currentCustomerItems[i].Name);
                    }
                    UpdateAmount();
                }
            }

            else
            {
                CartListBox.Items.Clear();
                NumberLabel.Text = "0";
            }
            
        }
        
        private void UpdateAmount()
        {
            NumberLabel.Text = Convert.ToString(Math.Round(_currentCustomer.Cart.Amount, 2)); 
        }

        /// <summary>
        /// Метод очищающий корзину пользователя.
        /// </summary>
        private void ClearCart()
        {
            if (CartListBox.Items.Count != 0 && CustomerComboBox.SelectedIndex != -1)
            {
                int length = _currentCustomerItems.Count;
                for (int i = 0; i < length; i++)
                {
                    CartListBox.SelectedIndex = 0;
                    RemoveItemFromCart();
                }
            }
        }

        /// <summary>
        /// Метод который удаляет элемент из корзины покупателя.
        /// </summary>
        private void RemoveItemFromCart()
        {
            if (_currentCustomer != null && CartListBox.SelectedItem != null)
            {
                _currentCustomerItems.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.Remove(CartListBox.SelectedItem);
                UpdateAmount();
                if (CartListBox.Items.Count != 0)
                {
                    CartListBox.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            set
            {
                _customers = value;
            }
        }

        public CartsTab()
        {
            InitializeComponent();

            NumberLabel.Text = "0";
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            AddItemToCart();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCustomer();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            RemoveItemFromCart();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count != 0 && _currentCustomer != null)
            {
                Order order = new Order();
                order.Items = _currentCustomerItems;
                order.DeliveryAddress = _currentCustomer.Address;
                order.Status = OrderStatus.New;
                ClearCart();
                _currentCustomer.Orders.Add(order);
            }
        }
    }
}
