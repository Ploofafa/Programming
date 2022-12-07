using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента <see cref="AddressControl"/>.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт значение адреса.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Хранит переменную для подсказки пользователю.
        /// </summary>
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Метод заполнения полей нового адреса.
        /// </summary>
        public void UpdateAddress()
        {
            PostIndexTextBox.Text = Convert.ToString(Address.Index);
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Метод очищения всех текстбоксов для адреса.
        /// </summary>
        public void ClearAddressInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PostIndexTextBox.Text) == false)
            {
                try
                {
                    Address.Index = Convert.ToString(PostIndexTextBox.Text);
                    PostIndexTextBox.BackColor = AppColors.NormalColor;
                    _toolTip.SetToolTip(PostIndexTextBox, "");
                }
                catch (Exception exception)
                {
                    _toolTip.SetToolTip(PostIndexTextBox, exception.Message);
                    PostIndexTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CountryTextBox.Text) == false)
            {
                try
                {
                    Address.Country = Convert.ToString(CountryTextBox.Text);
                    CountryTextBox.BackColor = AppColors.NormalColor;
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(CountryTextBox, exception.Message);
                    CountryTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CityTextBox.Text) == false)
            {
                try
                {
                    Address.City = Convert.ToString(CityTextBox.Text);
                    CityTextBox.BackColor = AppColors.NormalColor;
                    _toolTip.SetToolTip(CityTextBox, "");
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(CityTextBox, exception.Message);
                    CityTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StreetTextBox.Text) == false)
            {
                try
                {
                    Address.Street = Convert.ToString(StreetTextBox.Text);
                    StreetTextBox.BackColor = AppColors.NormalColor;
                    _toolTip.SetToolTip(StreetTextBox, "");
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(StreetTextBox, exception.Message);
                    StreetTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BuildingTextBox.Text) == false)
            {
                try
                {
                    Address.Building = Convert.ToString(BuildingTextBox.Text);
                    BuildingTextBox.BackColor = AppColors.NormalColor;
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(BuildingTextBox, exception.Message);
                    BuildingTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ApartmentTextBox.Text) == false)
            {
                try
                {
                    Address.Apartment = Convert.ToString(ApartmentTextBox.Text);
                    ApartmentTextBox.BackColor = AppColors.NormalColor;
                }

                catch (Exception exception)
                {
                    _toolTip.SetToolTip(ApartmentTextBox, exception.Message);
                    ApartmentTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }
    }
}
