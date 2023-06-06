using System.Windows;
using Contacts.ViewModel;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM _vm = new MainVM();

        public MainWindow()
        {
            InitializeComponent();    
            this.DataContext = _vm;
            _vm.LoadContacts();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _vm.SaveContacts();
        }
    }
}