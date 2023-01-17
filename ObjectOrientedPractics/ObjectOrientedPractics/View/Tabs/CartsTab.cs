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
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки <see cref="CartsTab"/>.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Хранит выбранного покупателя.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Метод для создания нового заказа.
        /// </summary>
        private void CreateOrder()
        {
            if (CartListBox.Items.Count != 0 && _currentCustomer != null &&
                CustomerComboBox.SelectedIndex != -1)
            {
                UpdateDiscounts();
                UpdateDiscountCheckedListBox();

                if(_currentCustomer.IsPriority == false)
                {
                    Order order = new Order();
                    order.Items.AddRange(_currentCustomer.Cart.Items);
                    order.Address = _currentCustomer.Address;
                    order.Status = OrderStatus.New;
                    order.CustomerName = _currentCustomer.FullName;
                    order.IsPriority = false;
                    order.DiscountAmount = ApplyDiscounts();
                    _currentCustomer.Orders.Add(order);
                }

                else
                {
                    PriorityOrder order = new PriorityOrder();
                    order.Items.AddRange(_currentCustomer.Cart.Items);
                    order.Address = _currentCustomer.Address;
                    order.Status = OrderStatus.New;
                    order.CustomerName = _currentCustomer.FullName;
                    order.IsPriority = true;
                    order.DiscountAmount = ApplyDiscounts();
                    _currentCustomer.Orders.Add(order);
                }
                
                ClearNumbers();
                ClearCart();
            }
        }

        /// <summary>
        /// Обновляет все скидки после покупки.
        /// </summary>
        private void UpdateDiscounts()
        {
            for(var i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                _currentCustomer.Discounts[i].Update(_currentCustomer.Cart.Items);
            }
        }

        /// <summary>
        /// Обнуляет все значения стоимости для пустой корзины.
        /// </summary>
        private void ClearNumbers()
        {
            NumberLabel.Text = "0";
            DiscountNumberLabel.Text = "0";
            TotalNumberLabel.Text = "0";
        }

        /// <summary>
        /// Метод для обновления данных на вкладке.
        /// </summary>
        public void RefreshData()
        {
            CartListBox.Items.Clear();
            ItemsListBox.Items.Clear();
            CustomerComboBox.Items.Clear();
            DiscountsCheckedListBox.Items.Clear();
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
            if (_customers != null)
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
                _currentCustomer.Cart.Items.Add(_items[ItemsListBox.SelectedIndex]);
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
                CartListBox.Items.Clear();
                if (_currentCustomer.Cart.Items.Count > 0)
                {
                    for (int i = 0; i < _currentCustomer.Cart.Items.Count; i++)
                    {
                        CartListBox.Items.Add(_currentCustomer.Cart.Items[i].Name);
                    }
                    UpdateAmount();
                }

                else
                {
                    CartListBox.Items.Clear();
                    ClearNumbers();
                }

                UpdateDiscountCheckedListBox();
                UpdateDiscountNumber();
            }
        }
        
        private void UpdateAmount()
        {
            if(_currentCustomer.Cart.Items.Count != 0)
            {
                NumberLabel.Text = Convert.ToString(Math.Round(_currentCustomer.Cart.Amount, 2));
            }

            else
            {
                ClearNumbers();
            }
        }

        /// <summary>
        /// Метод очищающий корзину пользователя.
        /// </summary>C
        private void ClearCart()
        {
            if (CartListBox.Items.Count != 0 && CustomerComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                _currentCustomer.Cart.Items.Clear();
                UpdateAmount();
            }
        }

        /// <summary>
        /// Метод который удаляет элемент из корзины покупателя.
        /// </summary>
        private void RemoveItemFromCart()
        {
            if (_currentCustomer != null && CartListBox.SelectedItem != null)
            {
                _currentCustomer.Cart.Items.Remove
                    (_currentCustomer.Cart.Items[CartListBox.SelectedIndex]);
                CartListBox.Items.Remove(CartListBox.SelectedItem);
                UpdateAmount();
                if (CartListBox.Items.Count != 0)
                {
                    CartListBox.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Обновляет список доступных скидок.
        /// </summary>
        private void UpdateDiscountCheckedListBox()
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                DiscountsCheckedListBox.Items.Clear();

                for (var i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    DiscountsCheckedListBox.Items.Add
                        (_currentCustomer.Discounts[i].Info);
                    DiscountsCheckedListBox.SetItemChecked(i, true);
                }
            }
        }
        
        /// <summary>
        /// Применяет к заказу все выбранные скидки.
        /// </summary>
        private double ApplyDiscounts()
        {
            for (var i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                double discountAmount = 0;
                if (DiscountsCheckedListBox.GetItemChecked(i) == true)
                {
                    discountAmount  += _currentCustomer.Discounts[i].Calculate(
                        _currentCustomer.Cart.Items);
                }
                return discountAmount;
            }

            return 0;
        }

        private void UpdateDiscountNumber()
        {
            if (CustomerComboBox.SelectedIndex != -1 && _currentCustomer.Cart.Items.Count > 0)
            {
                double discountNumber = 0;
                for (var i = 0; i < _currentCustomer.Discounts.Count ; i++)
                {
                    if (DiscountsCheckedListBox.GetItemChecked(i) == true)
                    {
                        discountNumber += _currentCustomer.Discounts[i].Calculate(
                            _currentCustomer.Cart.Items);
                    }
                }

                DiscountNumberLabel.Text = Convert.ToString(Math.Ceiling(discountNumber));
                TotalNumberLabel.Text = Convert.ToString(
                    _currentCustomer.Cart.Amount - Math.Ceiling(discountNumber));
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

            ClearNumbers();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            AddItemToCart();
            UpdateDiscountNumber();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCustomer();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            RemoveItemFromCart();
            UpdateDiscountNumber(); 
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
            ClearNumbers();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            CreateOrder();
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountNumber();
        }
    }
}
