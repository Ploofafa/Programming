using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming
{
    public partial class MainForm : Form
    { 
        class Enumss
        {
            public enum Colors
            {
                Белый,
                Чёрный,
                Синий,
                Серебрянный,
                Оранжевый,
                Красный
            }
            public enum Genre
            {
                Комедия,
                Триллер,
                боевик,
                ужас,
                блокбастер
            }
            public enum Manufacturers
            {
                Lg,
                Sony,
                Huawei,
                Apple,
                Google,
                Lenovo,
                Asus
            }
            public enum Season
            {
                Summer,
                Winter,
                Spring,
                Autumn
            }
            public enum StudyForm
            {
                Очная,
                Заочная,
                Вечерняя,
                Дистанционная
            }
            public enum Weekday
            {
                Monday = 1,
                Tuesday = 2,
                Wednesday = 3,
                Thursday = 4,
                Friday = 5,
                Saturday = 6,
                Sunday = 7
            }
        }


        public MainForm()
        {
            InitializeComponent();
        }
        Label WinterLabelBox = new Label();
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexBox.Clear();
            switch (EnumListBox.SelectedItem)
            {

                case "Colors":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Enumss.Colors)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Enumss.Colors), i));
                    }
                    break;
                case "Genre":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Enumss.Genre)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Enumss.Genre), i));
                    }
                    break;
                case "Manufacturers":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Enumss.Manufacturers)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Enumss.Manufacturers), i));
                    }
                    break;
                case "Season":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Enumss.Season)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Enumss.Season), i));
                    }
                    break;
                case "StudyForm":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Enumss.StudyForm)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Enumss.StudyForm), i));
                    }
                    break;
                case "Weekday":
                    ValuesListBox.Items.Clear();
                    foreach (int i in Enum.GetValues(typeof(Enumss.Weekday)))
                    {
                        ValuesListBox.Items.Add(Enum.GetName(typeof(Enumss.Weekday), i));
                    }
                    break;
                case null:
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String curItem = ValuesListBox.SelectedItem.ToString();
            String EnumItem = EnumListBox.SelectedItem.ToString();
            switch (EnumListBox.SelectedItem) 
            {
                case "Weekday":
                foreach (int i in Enum.GetValues(typeof(Enumss.Weekday)))
                    {
                        if (Enum.GetName(typeof(Enumss.Weekday), i) == curItem)
                        {
                            IndexBox.Text = Convert.ToString(i - 1);
                        }
                    }
                    break;
                
                case "Colors":
                foreach (int i in Enum.GetValues(typeof(Enumss.Colors)))
                    {
                        if (Enum.GetName(typeof(Enumss.Colors), i) == curItem)
                        {
                            IndexBox.Text = Convert.ToString(i);
                        }
                    }
                    break;
                
                case "Genre":
                foreach (int i in Enum.GetValues(typeof(Enumss.Genre)))
                    {
                        if (Enum.GetName(typeof(Enumss.Genre), i) == curItem)
                        {
                            IndexBox.Text = Convert.ToString(i);
                        }
                    }
                    break;
                
                case "Manufacturers": 
                foreach (int i in Enum.GetValues(typeof(Enumss.Manufacturers)))
                    {
                        if (Enum.GetName(typeof(Enumss.Manufacturers), i) == curItem)
                        {
                            IndexBox.Text = Convert.ToString(i);
                        }
                    }
                    break;
                
                case "Season":
                    foreach (int i in Enum.GetValues(typeof(Enumss.Season)))
                    {
                        if (Enum.GetName(typeof(Enumss.Season), i) == curItem)
                        {
                            IndexBox.Text = Convert.ToString(i);
                        }
                    }
                    break;
                case "StudyForm":
                    foreach (int i in Enum.GetValues(typeof(Enumss.StudyForm)))
                    {
                        if (Enum.GetName(typeof(Enumss.StudyForm), i) == curItem)
                        {
                            IndexBox.Text = Convert.ToString(i);
                        }
                    }
                    break;
            }
                
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            ParseTextOutput.Text = "";
            string UserInput = WeekdayTextBox.Text.ToString();
            
            foreach (int day in Enum.GetValues(typeof(Enumss.Weekday)))
            {
                if (Enum.GetName(typeof(Enumss.Weekday), day) == UserInput)
                    {
                    ParseTextOutput.Text = $"Это день недели ({Enum.GetName(typeof(Enumss.Weekday), day)} = {day})";
                    }   
            }
            if (ParseTextOutput.Text == "") 
            {
                ParseTextOutput.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            
            WinterLabelBox.Visible = false;
            GroupBoxSeason.BackColor = Color.White;
            SeasonComboBox.ForeColor = Color.Black;
            switch (SeasonComboBox.SelectedItem)
            { 
                case "Summer":
                    MessageBox.Show("Ура! Солнце!", "Summer");
                    break;
                case "Winter":
                    WinterLabelBox.Parent = GroupBoxSeason;
                    WinterLabelBox.Location = new Point(10, 80);
                    WinterLabelBox.Text = "Бррр! Холодно";
                    WinterLabelBox.BringToFront();
                    WinterLabelBox.Visible = true;
                    break;
                case "Spring":
                    GroupBoxSeason.BackColor = Color.Chartreuse;
                    break;
                case "Autumn":
                    SeasonComboBox.ForeColor = Color.Orange;
                    break;

            }
        }

      
    }
}
