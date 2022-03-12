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

namespace Programming.View
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
            EnumListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumListBox.SelectedIndex = 0;
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexBox.Clear();
            switch (EnumListBox.SelectedItem)
            {
                case Programming.View.Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Programming.View.Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Programming.View.Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CuredIndex = ValuesListBox.SelectedItem;
            IndexBox.Text = ((int)CuredIndex).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(WeekdayTextBox.Text, out day))
            {
                ParseTextOutput.Text = $"Это день недели ({day.ToString()} = {(int)day + 1}).";
            }

            else
            {
                ParseTextOutput.Text = "Такого дня недели не существует :(";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            WinterLabel.Visible = false;
            GroupBoxSeason.BackColor = Color.White;
            SeasonComboBox.ForeColor = Color.Black;
            
            switch (SeasonComboBox.SelectedItem)
            { 
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!", "Summer");
                    break;
                case Season.Winter:
                    WinterLabel.Visible = true;
                    break;
                case Season.Spring:
                    GroupBoxSeason.BackColor = Color.Chartreuse;
                    break;
                case Season.Autumn:
                    SeasonComboBox.ForeColor = Color.Orange;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = Convert.ToString(NumberPhone.Text);
            Contact contact1 = new Contact();
            contact1.MakeContact("das", "mixovith@mail.ru", "dsa", number);
            MessageBox.Show(contact1.GetNumber(contact1));
        }
    }
}
