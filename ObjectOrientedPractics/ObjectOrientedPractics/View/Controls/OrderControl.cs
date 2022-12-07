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
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Хранит логику пользовательского элемента <see cref="AddressControl"/>.
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Хранит переменную с нужным заказом.
        /// </summary>
        Order _order;

        /// <summary>
        /// Возвращает и задаёт значение заказа.
        /// </summary>
        public Order Order
        {
            get
            {
                return _order;
            }

            set
            {
                _order = value;
            }
        }

        /// <summary>
        /// Обновляет все значения в информационных боксах по заданном заказу.
        /// </summary>
        public void UpdateOrder()
        {
            IDTextBox.Text = Convert.ToString(Order.ID);
            CreatedDateTextBox.Text = Convert.ToString(Order.OrderCreationDate);
            StatusComboBox.SelectedIndex =(int) Order.Status;
        }

        public OrderControl()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_order != null)
            {
                int index = StatusComboBox.SelectedIndex;
                _order.Status = (OrderStatus)Enum.GetValues(typeof(OrderStatus)).GetValue(index);
            }
        }
    }
}
