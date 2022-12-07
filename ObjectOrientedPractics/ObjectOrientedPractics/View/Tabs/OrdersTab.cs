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
        private void UpdateInformationOnRightPanel()
        {
            if (dataGridView1.CurrentRow != null)
            {
                Order order = _orders[dataGridView1.CurrentRow.Index];
                NumberLabel.Text = Convert.ToString(order.Amount);
                for (int i = 0; i < order.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(order.Items[i].Name);
                }
                orderControl1.Order = order;
                orderControl1.UpdateOrder();
                addressControl1.Address = order.Address;
                addressControl1.UpdateAddress();
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
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Clear();
            UpdateInformationOnRightPanel();
        }
    }
}
