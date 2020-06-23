using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialProject
{
    internal class PolynomialFunction
    {
        private int exponent;
        public double[] coefficients;
        public double[] derivativeCoefficients;

        public PolynomialFunction(double[] newCoefficients)
        {
            coefficients = newCoefficients;

            int n = coefficients.Length;
            exponent = n - 1;
            derivativeCoefficients = new double[n - 1];
        }

        public void DisplayPolynomial()
        {
            Console.WriteLine("\nCalculated polynomial: ");
            Console.Write("f(x) = ");

            for (int i = 0; i < coefficients.Length; i++)
            {
                if (exponent > 0)
                {
                    Console.Write("{0}x^{1}", Math.Round(coefficients[i], 4), exponent);
                }
                else
                {
                    Console.Write(Math.Round(coefficients[i], 2));
                }

                exponent--;
            }
            Console.WriteLine();
        }

        public double[] CalculatePolynomial()
        {
            double[] result = new double[3];
            //int exp = exponent;
            for (int i = 0; i < 3; i++)
            {
                int n = -1;
                for (int j = 0; j < coefficients.Length; j++)
                {
                    result[i] += coefficients[j] * Math.Pow((n + i), exponent);
                    exponent--;
                }
                exponent = coefficients.Length - 1;
            }
            return result;
        }

        public double[] getDerivativeCoefficient()
        {
            int jumpExp = exponent;
            for (int i = 0; i < exponent; i++)
            {
                derivativeCoefficients[i] = jumpExp * coefficients[i];
                jumpExp--;
            }
            return derivativeCoefficients;
        }

        public void DisplayDerivative()
        {
            Console.WriteLine("\nDerivative: ");
            Console.Write("f'(x) = ");
            int derivativeExp = derivativeCoefficients.Length - 1;
            for (int i = 0; i < exponent; i++)
            {
                if (derivativeExp > 0)
                {
                    Console.Write("{0}x^{1}", Math.Round(derivativeCoefficients[i], 5), derivativeExp);
                }
                else
                {
                    Console.Write("{0}", Math.Round(derivativeCoefficients[i], 5));
                }
                derivativeExp--;
            }
            Console.WriteLine();
        }

        public void DisplayPolynomialResult()
        {
            double[] value = CalculatePolynomial();
            int x = -1;
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine("f({0}) = {1}", x + i, Math.Round(value[i], 4));
            }
        }
    }
}