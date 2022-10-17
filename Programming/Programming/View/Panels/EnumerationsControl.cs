using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

namespace Programming.Model.Panels
{
    /// <summary>
    /// Содержит логику полльзовательского элемента <see cref="EnumerationsControl"/>.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumListBox.DataSource = Enum.GetValues(typeof(Programming.View.Enums));
            ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
            IndexBox.Text = 0.ToString();
        }

        private void ValuesListBox_SystemColorsChanged(object sender, EventArgs e)
        {
            var currentIndex = ValuesListBox.SelectedItem;
            IndexBox.Text = ((int)currentIndex).ToString();
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexBox.Clear();
            IndexBox.Text = 0.ToString();
            switch (EnumListBox.SelectedItem)
            {
                case View.Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;
                case Programming.View.Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Programming.View.Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Programming.View.Enums.StudyForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(StudyForm));
                    break;
                case Programming.View.Enums.Manufacturers:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacturers));
                    break;
                case Programming.View.Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
            }
        }
    }
}
