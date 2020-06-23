using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialProject
{
    public class Point
    {
        public double x, y;

        public Point(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
    }
    public class CartesianCoordinate
    {
        public List<Point> coordinatesList;

        public CartesianCoordinate()

        {
            coordinatesList = new List<Point>();
        }

        public CartesianCoordinate(List<Point> newCoordinatesList)
        {
            coordinatesList = newCoordinatesList;
        }

        public void SetCoordinates()
        {
            bool cont = true;
            int nPoint = 1;
            string input;

            while (cont)
            {
                Console.Write($"Point#{nPoint}: ");
                input = Console.ReadLine();

                string[] spl = input.Split(',');

                if (input.ToUpper() != "END")
                {
                    coordinatesList.Add(new Point(double.Parse(spl[0]), double.Parse(spl[1])));
                    nPoint++;
                }
                else
                {
                    cont = false;
                }
            }
        }

        public void DisplayCoordinate()
        {
            for (int i = 0; i < coordinatesList.Count; i++)
            {
                Console.Write("({0},{1})", coordinatesList[i].x, coordinatesList[i].y);
                Console.WriteLine();
            }
        }
    }
}
