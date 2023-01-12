using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {

        private PriorityOrder priorityOrder = new PriorityOrder();

        public List<Item> Items { get; set; }

        private void AddItem()
        {
            Random random = new Random();
            Item item = Items[random.Next(0, Items.Count)];
            priorityOrder.Items.Add(item);
            OrderItemsListBox.Items.Add(item.Name);
            NumberLabel.Text = Convert.ToString(priorityOrder.Amount);
        }

        private void RemoveItem()
        {
            priorityOrder.Items.Remove(priorityOrder.Items[OrderItemsListBox.SelectedIndex]);
            OrderItemsListBox.Items.Remove
                (OrderItemsListBox.Items[OrderItemsListBox.SelectedIndex]);
            
            if (OrderItemsListBox.Items.Count > 0)
            {
                OrderItemsListBox.SelectedIndex = 0;
            }

            else
            {
                OrderItemsListBox.SelectedIndex = -1;
            }
            NumberLabel.Text = Convert.ToString(priorityOrder.Amount);
        }

        private void ClearOrder()
        {
            OrderItemsListBox.Items.Clear();
            priorityOrder.Items.Clear();
            NumberLabel.Text = Convert.ToString(priorityOrder.Amount);
            priorityOrder = new PriorityOrder();
            NewOrder();
        }

        private void NewOrder()
        {
            NumberLabel.Text = "0";
            orderControl1.Order = priorityOrder;
            orderControl1.UpdateOrder();
        }

        public PriorityOrdersTab()
        {
            InitializeComponent();

            NewOrder();
            DeliveryTimeComboBox.Items.AddRange(PriorityOrder.RangeTime);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex != -1)
            {
                RemoveItem();
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }
    }
}
