using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.Model.Panels
{

    /// <summary>
    /// Содержит логику пользовательского элемента <see cref="ClassesRectangle"/>.
    /// Создаёт заданное количество прямоугольников, реализует поиск по большей ширине.
    /// </summary>
    public partial class ClassesRectangle : UserControl
    {

        public Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private readonly Color _normalColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private ToolTip _toolTip = new ToolTip();

        private int _rectanglesCount = 5;

        private void InitRectangles()
        {
            _rectangles = new Rectangle[_rectanglesCount];
            Random random = new Random();
            string[] rectangleColor = new string[] { "Black", "Yellow", "Green",
                                                    "Blue", "Red", "White" };

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
                _rectangles[i].Color = rectangleColor[random.Next(0, rectangleColor.Length)];
            }
            RectangleListBox.SelectedIndex = 0;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double maxWidth = -1;
            int currentIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        public ClassesRectangle()

        {
            InitializeComponent();

            InitRectangles();
            XCentreTextBox.ReadOnly = true;
            YCentreTextBox.ReadOnly = true;
            RectangleIdTextBox.ReadOnly = true;
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            RectangleLengthTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
            XCentreTextBox.Text = _currentRectangle.Centre.X.ToString();
            YCentreTextBox.Text = _currentRectangle.Centre.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleLengthTextBox.BackColor = _normalColor;
            try
            {
                _currentRectangle.Height = Convert.ToInt32(RectangleLengthTextBox.Text);
                _toolTip.SetToolTip(RectangleLengthTextBox, "");
            }
            catch (Exception exception)
            {
                RectangleLengthTextBox.BackColor = _errorColor;
                _toolTip.SetToolTip(RectangleLengthTextBox, exception.Message);
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = _normalColor;
            try
            {
                _currentRectangle.Width = Convert.ToInt32(RectangleWidthTextBox.Text);
                _toolTip.SetToolTip(RectangleWidthTextBox, "");
            }
            catch (Exception exception)
            {
                RectangleWidthTextBox.BackColor = _errorColor;
                _toolTip.SetToolTip(RectangleWidthTextBox, exception.Message);
            }
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
