using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Defines methods for calculating the area and the peirmeter of a figure.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculating the area of a figure.
        /// </summary>
        /// <returns>
        /// Area value.
        /// </returns>
        double CalculateArea();

        /// <summary>
        /// Calculating the perimeter of a figure.
        /// </summary>
        /// <returns>
        /// Perimeter value.
        /// </returns>
        double CalculatePerimeter();
    }
}
