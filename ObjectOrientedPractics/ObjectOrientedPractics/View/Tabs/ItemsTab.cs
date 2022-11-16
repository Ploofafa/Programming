using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{

    /// <summary>
    /// Содержит логику пользовательского элемента <see cref="ItemsTab"/>.
    /// Даёт возможность добавления, удаления, редактирования товаров в БД.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Хранит список всех товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Хранит экземпляр выбранного товара.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Хранит переменную для подсказок пользователю в элементах.
        /// </summary>
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Обновляет название элемента в текстбокса.
        /// </summary>
        private void UpdateItemInfo()
        {
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = ($"{_currentItem.Name}");
        }

        /// <summary>
        /// Заполняет лист бокс имеющимися данными.
        /// </summary>
        public void UpdateListBox()
        {
            if (_items.Count > 0)
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    ItemsListBox.Items.Add(_items[i].Name);
                }
            }
        }

        /// <summary>
        /// Метод для добавления элемента в листбокс.
        /// </summary>
        private void ItemAdd()
        {
            Item item = new Item();
            _currentItem = item;
            _items.Add(item);
            ItemsListBox.Items.Add($"{_currentItem.Name}");
            ItemsListBox.SelectedIndex = Items.Count - 1;
            UpdateItemInfo();
        }

        /// <summary>
        /// Метод для очищения всех полей.
        /// </summary>
        private void ClearItemInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        /// <summary>
        /// Метод для удаления экземпляра списка из базы.
        /// </summary>
        private void ItemRemove()
        {
            if (ItemsListBox.Items.Count > 0 & ItemsListBox.SelectedIndex != -1)
            {
                Items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                if (ItemsListBox.Items.Count != 0)
                {
                    ItemsListBox.SelectedIndex = 0;
                }

                else
                {
                    ClearItemInfo();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
            }
        }

        public ItemsTab()
        {
            InitializeComponent();

            foreach (int index in Enum.GetValues(typeof(Category)))
            {
                ItemCategoryComboBox.Items.Add(Enum.GetName(typeof(Category), index));
            }
        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            ItemAdd();
        }

        private void RemoveItemsButton_Click(object sender, EventArgs e)
        {
            ItemRemove();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedIndex != -1)
            {
                _currentItem = Items[ItemsListBox.SelectedIndex];
                IdTextBox.Text = _currentItem.Id.ToString();
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
                CostTextBox.Text = _currentItem.Cost.ToString();
                ItemCategoryComboBox.SelectedIndex =(int) _currentItem.Category;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CostTextBox.Text) == false & _items.Count != 0)
            {
                try
                {
                    _currentItem.Cost = double.Parse(CostTextBox.Text);
                    _toolTip.SetToolTip(CostTextBox, "");
                    CostTextBox.BackColor = AppColors.NormalColor;
                }

                catch (Exception exception)
                {
                    CostTextBox.BackColor = AppColors.ErrorColor;
                    _toolTip.SetToolTip(CostTextBox, exception.Message);
                }
            }
               
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) == false & _items.Count != 0)
            {
                try
                {
                    _currentItem.Name = Convert.ToString(NameTextBox.Text);
                    _toolTip.SetToolTip(NameTextBox, "");
                    NameTextBox.BackColor = AppColors.NormalColor;
                    UpdateItemInfo();
                }

                catch (Exception exception)
                {
                    NameTextBox.BackColor = AppColors.ErrorColor;
                    _toolTip.SetToolTip(NameTextBox, exception.Message);
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTextBox.Text) == false & _items.Count != 0)
            {
                try
                {
                    _currentItem.Info = Convert.ToString(DescriptionTextBox.Text);
                    _toolTip.SetToolTip(DescriptionTextBox, "");
                    DescriptionTextBox.BackColor = AppColors.NormalColor;
                }

                catch (Exception exception)
                {
                    DescriptionTextBox.BackColor = AppColors.ErrorColor;
                    _toolTip.SetToolTip(DescriptionTextBox, exception.Message);
                }
            }
        }

        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItem.Category =(Category)ItemCategoryComboBox.SelectedIndex;
        }
    }
}
