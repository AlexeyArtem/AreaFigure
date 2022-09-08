using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Contains a set of three numbers that determine the size of the triangle.
    /// </summary>
    public class Triangle : IFigure
    {
        private double side1;
        private double side2;
        private double side3;

        /// <summary>
        /// Initialize a new instance <see cref="Triangle"/> class
        /// </summary>
        /// <param name="side1">Side 1 length</param>
        /// <param name="side2">Side 2 length</param>
        /// <param name="side3">Side 3 length</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("One side length less or equal 0");

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            if (!CheckExistence())
                throw new ArgumentException("One side of the triangle is greater than the sum of the other two sides");
        }

        /// <summary>
        /// Gets or sets the length of side 1
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public double Side1 
        {
            get => side1;
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Side 1 length less or equal 0");

                if (!CheckExistence())
                    throw new ArgumentException("One side of the triangle is greater than the sum of the other two sides");

                side1 = value;
            }
        }

        /// <summary>
        /// Gets or sets the length of side 2
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public double Side2
        {
            get => side2;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side 2 length less or equal 0");

                if (!CheckExistence())
                    throw new ArgumentException("One side of the triangle is greater than the sum of the other two sides");

                side2 = value;
            }
        }

        /// <summary>
        /// Gets or sets the length of side 3
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public double Side3
        {
            get => side3;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side 3 length less or equal 0");

                if (!CheckExistence())
                    throw new ArgumentException("One side of the triangle is greater than the sum of the other two sides");

                side3 = value;
            }
        }

        /// <summary>
        /// Tests whether triangle rectangular.
        /// </summary>
        public bool IsRectangular
        {
            get 
            {
                if ((Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2)) || 
                    (Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2)) || 
                    (Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2)))
                    return true;
                
                return false;
            }
        }

        /// <summary>
        /// Tests whether triangle equilateral.
        /// </summary>
        public bool IsEquilateral
        {
            get 
            {
                if (Side1 == Side2 && Side1 == Side3 && Side2 == Side3)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Tests whether triangle isosceles.
        /// </summary>
        public bool IsIsosceles 
        {
            get 
            {
                if (side1 == side2 || side1 == side3 || side2 == side3)
                    return true;
                return false;
            }
        }

        private bool CheckExistence() 
        {
            if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
                return false;
            return true;
        }

        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            double s = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return s;
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
