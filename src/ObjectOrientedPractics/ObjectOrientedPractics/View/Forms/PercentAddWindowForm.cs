using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class PercentAddWindowForm : Form
    {
        /// <summary>
        /// Задаёт и возвращает категорию товара со скидкой.
        /// </summary>
        public Category Category { get; set; }

        public PercentAddWindowForm()
        {
            InitializeComponent();
            foreach (int index in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(Enum.GetName(typeof(Category), index));
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(CategoryComboBox.SelectedIndex != -1)
            {
                Category = (Category) CategoryComboBox.SelectedIndex;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
