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
    public partial class WeekdayParsing : UserControl
    {
        public WeekdayParsing()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day = new Weekday();
            Enum.TryParse(WeekdayTextBox.Text, out day);
            if (Enum.TryParse(WeekdayTextBox.Text, out day) & (int)day < 7)
            {
                ParseTextOutput.Text = $"Это день недели ({day.ToString()} = {(int)day + 1}).";
            }
            else
            {
                ParseTextOutput.Text = "Такого дня недели не существует :(";
            }
        }
    }
}
