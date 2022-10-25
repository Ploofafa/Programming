using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ItemSerializer.SaveItemsToFile(ItemsTab.Items);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ItemsTab.Items.AddRange(ItemSerializer.LoadItemsToFile());
            for (int i = 0; i < ItemsTab.Items.Count; i++)
            {
                ItemsTab.ItemsListBox.Items.Add(ItemsTab.Items[i].Name);
            }
        }
    }
}