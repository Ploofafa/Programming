using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private List<Item> items = new List<Item>();

        private PointsDiscount points = new PointsDiscount();

        private PercentDiscount percent = new PercentDiscount(Model.Enums.Category.Tools);

        private Item testItem = new Item("bubble", "", 5000, Model.Enums.Category.Tools);
        
        public DiscountsTab()
        {
            InitializeComponent();
            items.Add(testItem);
            DiscountNumberLabel.Text = "0";
            AmountLabel.Text = "0";
            InfoLabel.Text = points.Info;
            percent.Accumulated = 4999;
            percent.Discount = 0.04;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AmountLabel.Text = Convert.ToString(testItem.Cost);
            DiscountNumberLabel.Text = Convert.ToString(points.Calculate(items)); 
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            items[0].Cost = points.Apply(items);
            AmountLabel.Text = Convert.ToString(items[0].Cost);
            ApplyButton.Enabled = false;
            CalculateButton.Enabled = false;
            DiscountNumberLabel.Text = "0";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        { 
            points.Update(items);
            InfoLabel.Text = points.Info;
        }

        private void CalculatePercentButton_Click(object sender, EventArgs e)
        {
            InfoPercentDiscountLabel.Text = percent.Info;
            ProductsNumberPercentLabel.Text = Convert.ToString(testItem.Cost);
            NumberDiscountPercentLabel.Text = Convert.ToString(percent.Calculate(items));
        }

        private void ApplyPercentButton_Click(object sender, EventArgs e)
        {
            items[0].Cost = percent.Apply(items);
            ProductsNumberPercentLabel.Text = Convert.ToString(items[0].Cost);
            ApplyPercentButton.Enabled = false;
            CalculatePercentButton.Enabled = false;
            DiscountNumberLabel.Text = "0";
        }

        private void UpdatePercentButton_Click(object sender, EventArgs e)
        {
            percent.Update(items);
            InfoPercentDiscountLabel.Text = percent.Info;
        }
    }
}
