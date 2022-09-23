using ObjectOrientedPractics.Model;
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
    /// <summary>
    /// Содержит логику пользовательского интерфейса <see cref="CustomersTab"/>.
    /// Даёт возможности добавления, удаления, редактирования покупателей в БД.
    /// </summary>
    public partial class CustomersTab : UserControl
    {

        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Хранит переменную для подсказок пользователю в элементах.
        /// </summary>
        private ToolTip _toolTip = new();

        private void CustomerAdd()
        {

        }
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
