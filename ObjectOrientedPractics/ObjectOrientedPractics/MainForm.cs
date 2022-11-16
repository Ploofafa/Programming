using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ ��������� ������ <see cref="Store"/>.
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            var itemsData = StoreSerializer.LoadItemsData();
            if (itemsData != null)
            {
                itemsTab1.Items = itemsData;
            }
            itemsTab1.UpdateListBox();

            var customersData = StoreSerializer.LoadCustomersData();
            if (customersData != null)
            {
                customerTab1.Customers = customersData;
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
    }
}