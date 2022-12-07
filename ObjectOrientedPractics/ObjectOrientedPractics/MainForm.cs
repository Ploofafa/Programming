using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит экземпляр класса <see cref="Store"/>.
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            var itemsData = StoreSerializer.LoadItemsData();
            if (itemsData != null)
            {
                itemsTab1.Items = itemsData;
                cartsTab1.Items = itemsData;
            }
            itemsTab1.UpdateListBox();
            cartsTab1.UpdateListBox();

            var customersData = StoreSerializer.LoadCustomersData();
            if (customersData != null)
            {
                customerTab1.Customers = customersData;
                cartsTab1.Customers = customersData;
                ordersTab1.Customers = customersData;
            }
            customerTab1.UpdateListBox();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _store.Customers = customerTab1.Customers;
            _store.Items = itemsTab1.Items;
            StoreSerializer.SaveData(_store.Customers);
            StoreSerializer.SaveData(_store.Items);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                cartsTab1.RefreshData();
            }

            if (TabControl.SelectedIndex == 3)
            {
                ordersTab1.RefreshData();
            }
        }
    }
}