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

namespace Programming.Model.Panels
{
    public partial class SeasondHandler : UserControl
    {
        public SeasondHandler()
        {
            InitializeComponent();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void SeasondHandler_Load(object sender, EventArgs e)
        {
            AutumnLabel.Visible = false;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            SeasonComboBox.ForeColor = Color.Black;
            SeasonButton.BackColor = Color.White;

            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Winter:
                    SeasonButton.BackColor = Color.Aqua;
                    break;
                case Season.Spring:
                    MessageBox.Show("Thr flowers have bloomed");
                    break;
                case Season.Summer:
                    SeasonComboBox.ForeColor = Color.Green;
                    break;
                case Season.Autumn:
                    AutumnLabel.Visible = true;
                    break;
            }
        }
    }
}
