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
    public partial class RectanglesCollisionControl : UserControl
    {
        private readonly Color _normalRectangleColor = Color.FromArgb(127, 127, 255, 127);

        private readonly Color _collisionRectangleColor = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _normalColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private ToolTip _toolTip = new ToolTip();

        private List<Rectangle> _rectangles = new List<Rectangle>(200);

        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();

        private int _rectanglesCount = 5;

        private void ItemAddListBox(Rectangle rectangle)
        {
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add($"{ rectangle.Id - _rectanglesCount}: (" +
                    $"X = {rectangle.Centre.X}; Y = {rectangle.Centre.Y};" +
                    $" W = {rectangle.Width}; H = {rectangle.Height})");
        }

        private void UpdateRectanglesInfo(Rectangle rectangle)
        {
            RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = ($"{rectangle.Id}: (" +
                    $"X = {rectangle.Centre.X}; Y = {rectangle.Centre.Y};" +
                    $" W = {rectangle.Width}; H = {rectangle.Height})");
        }

        private void PanelAddListBox(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point(rectangle.Centre.X, rectangle.Centre.Y);
            panel.Size = new Size(rectangle.Width, rectangle.Height);
            panel.BackColor = _normalRectangleColor;
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);
        }

        private void ChangedRectanglesPanel(Panel panel)
        {
            panel.Location = new Point(_currentRectangle.Centre.X, _currentRectangle.Centre.Y);
            panel.Size = new Size(_currentRectangle.Width, _currentRectangle.Height);
        }

        private void RectanglesDelete()
        {
            if (RectanglesListBox.Items.Count != 0)
            {
                _rectangles.RemoveAt(RectanglesListBox.SelectedIndex);
                CanvasPanel.Controls.Remove(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                _rectanglePanels.RemoveAt(RectanglesListBox.SelectedIndex);
                RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);
                if (RectanglesListBox.Items.Count != 0)
                {
                    RectanglesListBox.SelectedIndex = 0;
                }
            }
        }

        private void ClearRectangleInfo()
        {
            RectangleIdTextBox.Clear();
            RectangleYTextBox.Clear();
            RectangleWidthTextBox.Clear();
            RectangleHeightTextBox.Clear();
            RectangleXTextBox.Clear();
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = _normalRectangleColor;
            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int g = i + 1; g < _rectanglePanels.Count; g++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[g]))
                    {
                        _rectanglePanels[i].BackColor = _collisionRectangleColor;
                        _rectanglePanels[g].BackColor = _collisionRectangleColor;
                    }
                }
            }
        }

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            RectangleIdTextBox.ReadOnly = true;
        }

        private void RectanglesAddButton_MouseHover(object sender, EventArgs e)
        {
            RectanglesAddButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void RectanglesAddButton_MouseLeave(object sender, EventArgs e)
        {
            RectanglesAddButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RectanglesAddButton_MouseEnter(Object sender, EventArgs e)
        {
            RectanglesAddButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void RectanglesAddButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            rectangle.Id = rectangle.Id - _rectanglesCount;
            ItemAddListBox(rectangle);
            PanelAddListBox(rectangle);
            RectanglesListBox.SelectedIndex = RectanglesListBox.Items.Count - 1;
            FindCollisions();
        }

        private void RectanglesDeleteButton_MouseHover(object sender, EventArgs e)
        {
            RectangleDeleteButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RectanglesDeleteButton_MouseLeave(object sender, EventArgs e)
        {
            RectangleDeleteButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RectanglesDeleteButton_MouseEnter(Object sender, EventArgs e)
        {
            RectangleDeleteButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RectanglesDeleteButton(object sender, EventArgs e)
        {
            RectanglesDelete();
            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
                RectangleXTextBox.Text = _currentRectangle.Centre.X.ToString();
                RectangleYTextBox.Text = _currentRectangle.Centre.Y.ToString();
            }
            else
            {
                ClearRectangleInfo();
            }
        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = _normalColor;
            if (string.IsNullOrEmpty(RectangleWidthTextBox.Text) == false)
            {
                try
                {
                    _currentRectangle.Width = Int32.Parse(RectangleWidthTextBox.Text);
                    _toolTip.SetToolTip(RectangleWidthTextBox, "");
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                    UpdateRectanglesInfo(_currentRectangle);
                    FindCollisions();
                }
                catch (Exception exception)
                {
                    RectangleWidthTextBox.BackColor = _errorColor;
                    _toolTip.SetToolTip(RectangleWidthTextBox, exception.Message);
                }
            }
        }

        private void RectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleHeightTextBox.BackColor = _normalColor;
            if (string.IsNullOrEmpty(RectangleHeightTextBox.Text) == false)
            {
                try
                {
                    RectangleHeightTextBox.BackColor = _normalColor;
                    _currentRectangle.Height = Int32.Parse(RectangleHeightTextBox.Text);
                    _toolTip.SetToolTip(RectangleHeightTextBox, "");
                    UpdateRectanglesInfo(_currentRectangle);
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                    FindCollisions();
                }

                catch (Exception exception)
                {
                    RectangleHeightTextBox.BackColor = _errorColor;
                    _toolTip.SetToolTip(RectangleHeightTextBox, exception.Message);
                }
            }
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleXTextBox.BackColor = _normalColor;
            if (string.IsNullOrEmpty(RectangleXTextBox.Text) == false)
            {
                try
                {
                    _currentRectangle.Centre.X = Int32.Parse(RectangleXTextBox.Text);
                    _toolTip.SetToolTip(RectangleXTextBox, "");
                    UpdateRectanglesInfo(_currentRectangle);
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                    FindCollisions();
                }

                catch (Exception exception)
                {
                    RectangleXTextBox.BackColor = _errorColor;
                    _toolTip.SetToolTip(RectangleXTextBox, exception.Message);
                }
            }
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleYTextBox.BackColor = _normalColor;
            if (string.IsNullOrEmpty(RectangleYTextBox.Text) == false)
            {
                try
                {
                    _currentRectangle.Centre.Y = Int32.Parse(RectangleYTextBox.Text);
                    _toolTip.SetToolTip(RectangleYTextBox, "");
                    UpdateRectanglesInfo(_currentRectangle);
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                    FindCollisions();
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(RectangleYTextBox, exception.Message);
                    RectangleYTextBox.BackColor = _errorColor;
                }
            }
        }
    }
}
