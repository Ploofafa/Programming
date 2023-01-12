using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    /// Класс содержащий логику вкладки <see cref="OrdersTab"/>.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Хранит список заказов всех покупателей.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Хранит выбранный экземпляр заказа типа <see cref="Order"/>.
        /// </summary>
        private Order _selectedOrder = new Order();

        /// <summary>
        /// Хранит выбранный экземпляр приоритетного заказа типа <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder = new PriorityOrder();

        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private List<Customer> _customers;

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

        public void RefreshData()
        {
            SetData();
        }

        /// <summary>
        /// Метод обновляет список заказов всех покупателей.
        /// </summary>
        private void UpdateOrders()
        {
            _orders = new List<Order>();
            if (_customers != null)
            {
                for (int i = 0; i < _customers.Count; i++)
                {
                    Customer customer = _customers[i];
                    if (customer.Orders != null)
                    {
                        for (int g = 0; g < customer.Orders.Count; g++)
                        {
                            _orders.Add(customer.Orders[g]);
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Обновляет всю имеющуюся информацию по заказу.
        /// </summary>
        private void UpdateInformationAboutOrder()
        {
            if (dataGridView1.CurrentRow != null)
            {
                for (int i = 0; i < _selectedOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_selectedOrder.Items[i].Name);
                }
                orderControl1.Order = _selectedOrder;
                orderControl1.UpdateOrder();
                addressControl1.Address = _selectedOrder.Address;
                addressControl1.UpdateAddress();
                NumberLabel.Text = Convert.ToString(_selectedOrder.Amount);
                PriorityOptionsPanel.Visible = false;
            }
        }

        /// <summary>
        /// Обновляет информацию на правой панели, для приоритетного заказа.
        /// </summary>
        private void UpdateInformationAboutPriorityOrder()
        {
            if (dataGridView1.CurrentRow != null)
            {
                PriorityOptionsPanel.Visible = true;
                DeliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DesiredTime;
                for (int i = 0; i < _selectedOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_selectedOrder.Items[i].Name);
                }
                orderControl1.Order = _selectedOrder;
                orderControl1.UpdateOrder();
                addressControl1.Address = _selectedOrder.Address;
                addressControl1.UpdateAddress();
                NumberLabel.Text = Convert.ToString(_selectedOrder.Amount);
                
            }
        }

        /// <summary>
        /// Функция для выбора нового заказа в DataGridView.
        /// </summary>
        private void ChangeSelectedOrder()
        {
            if (dataGridView1.CurrentRow != null)
            {
                _selectedOrder = _orders[dataGridView1.CurrentRow.Index];
                if (_selectedOrder.GetType() == typeof(PriorityOrder))
                {
                    _selectedPriorityOrder = (PriorityOrder)_selectedOrder;
                }

                else
                {
                    _selectedPriorityOrder = null;
                }
            }
        }

        /// <summary>
        /// Метод для заполнения всех строк с заказами.
        /// </summary>
        public void SetData()
        {
            UpdateOrders();
            dataGridView1.DataSource = _orders;
            dataGridView1.Columns.Remove("Address");
        }

        public OrdersTab()
        {
            InitializeComponent();
            NumberLabel.Text = "0";
            DeliveryTimeComboBox.Items.AddRange(PriorityOrder.RangeTime);
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Clear();
            ChangeSelectedOrder();
            if (_selectedPriorityOrder == null)
            {
                UpdateInformationAboutOrder();
            }

            else
            {
                UpdateInformationAboutPriorityOrder();
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.DesiredTime = (string) DeliveryTimeComboBox.SelectedItem;
        }
    }
}
