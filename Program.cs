using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AreaFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure[] figures = new IFigure[] { new Circle(4), new Triangle(3, 4, 5) };

            foreach (IFigure f in figures)
            {
                Console.WriteLine("S = " + f.CalculateArea());
                Console.WriteLine("P = " + f.CalculatePerimeter() + "\n");
            }

            Console.Read();
        }
    }
}
