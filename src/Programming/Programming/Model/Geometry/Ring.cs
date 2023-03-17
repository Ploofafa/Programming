using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит информацию о кольце:
    /// внешний радиус, внутренний радиус, центр.
    /// </summary>
    public class Ring
    {

        /// <summary>
        /// Содержит информацию о внешнем радиусе, должен быть больше нуля
        /// и больше внутреннего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Содержит информацию о внутреннем радиусе, должен быть больше нуля
        /// и меньше внешнего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Содержит информацию о площади кольца, должна быть больше нуля.
        /// </summary>
        private double _area;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен быть больше нуля и
        /// больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть больше нуля и
        /// меньше внешнего радиуса</param>
        /// <param name="point">Координаты центра кольца.</param>
        public Ring(int outerRadius,
                    int innerRadius,
                    Point2D point)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Centre = point;
        }

        /// <summary>
        /// Возвращает и задаёт значение внешнего радиуса.
        /// Должно быть больше нуля и больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (_outerRadius < _innerRadius)
                {
                    throw new ArgumentException("Outer radius can't be less than inner radius");
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение внутреннего радиуса.
        /// Должно быть больше нуля и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (_innerRadius > _outerRadius)
                {
                    throw new ArgumentException("Inner radius can't be more then outer radius");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает значение площади кольца.
        /// Класс не контролирует значение площади.
        /// </summary>
        public double Area
        {
            get
            {
                _area = Math.Pow(this.OuterRadius, 2) * Math.PI - Math.Pow(this.InnerRadius, 2) * Math.PI;
                Validator.AssertOnPositiveValue(_area, nameof(Area));
                return _area;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение центра кольца.
        /// </summary>
        public Point2D Centre { get; set; }
    }
}
