using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Polynomial Function Project !!!");
            Console.WriteLine("Provide points in x y representation");
            List<Point> points = new List<Point>() { new Point(1, -1), new Point(-3, 6), new Point(5, 1) };
            CartesianCoordinate cooridnate = new CartesianCoordinate(points);
            cooridnate.DisplayCoordinate();

            EquationSystem equation = new EquationSystem(cooridnate);
            equation.SetMatrix();
            equation.DisplayMatrix();
            equation.DisplayResult();

            PolynomialFunction poly = new PolynomialFunction(equation.GetRoot());
            poly.DisplayPolynomial();
            poly.CalculatePolynomial();
            poly.DisplayPolynomialResult();
            poly.getDerivativeCoefficient();
            poly.DisplayDerivative();
        }
    }
}
