using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialProject
{
    public class EquationSystem : VendermodeMatrix
    {
        private readonly Calculator _calculator;

        public EquationSystem(CartesianCoordinate coordinate)
            : base(coordinate)
        {
            _calculator = new Calculator(matrix);
        }

        public double[] GetRoot()
        {
            _calculator.ForwardEliminationMatrix();
            _calculator.Pivoting();
            return _calculator.BackwardsSubstitution();
        }

        public void DisplayResult()
        {
            var result = GetRoot(); ;
            Console.WriteLine("\nResult: ");
            int numX = result.Length;
            for (int i = 0; i < numX; i++)
            {
                Console.WriteLine("X{0}: {1}", i + 1, result[i]);
            }
        }
    }
}
