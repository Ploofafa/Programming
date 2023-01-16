using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class ChooseCategoryForm : Form
    {
        /// <summary>
        /// Возвращает и задаёт значение категории товара на который предоставляется скидка.
        /// </summary>
        public Category Category { get; set; }

        public ChooseCategoryForm()
        {
            InitializeComponent();

            foreach (var index in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(Enum.GetName(typeof(Category), index));
            }
            
            CategoryComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Category = (Category)CategoryComboBox.SelectedIndex;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Category = new Category();
            this.Close();
        }
    }
}
