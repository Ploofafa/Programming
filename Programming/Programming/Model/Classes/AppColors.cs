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

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Хранит значение нормального цвета, для прямоугольников.
        /// </summary>
        public static Color NormalRectangleColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Хранит значение ошибочного цвета, для прямоугольников.
        /// </summary>
        public static Color CollisionColor = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Хранит нормальный цвет текстбокса.
        /// </summary>
        public static Color NormalColor = Color.White;

        /// <summary>
        /// Хранит цвет для текстбокса с ошибкой.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;
    }
}
