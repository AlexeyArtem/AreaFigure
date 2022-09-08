using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Contains the radius that defines the size of the circle.
    /// </summary>
    public class Circle : IFigure
    {
        private double radius;

        /// <summary>
        /// Initialize a new instance <see cref="Circle"/> class
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public Circle (double radius) 
        {
            Radius = radius;
        }

        /// <summary>
        ///  Gets or sets the length of radius
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius less or equal 0");

                radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
