using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquationsSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2 ... all d, /n where a1...N are coefficients and d is constant");
            Console.WriteLine("How many equations do you want to enter");

            int M;
            while (!int.TryParse(Console.ReadLine(), out M))
            {
                Console.WriteLine("Wrong Number");
            }

            int[,] A = new int[M, M + 1];

            for (int row = 0; row < M; row++)
            {
                Console.Write($"Eq #{row}: ");
                int numInput;
                for (int col = 0; col < M + 1; col++)
                {
                    while (!int.TryParse(Console.ReadLine(), out numInput))
                    {

                    }
                    A[row, col] = numInput;
                }
            }
            //Display Matrix
            for (int row = 0; row < M; row++)
            {
                for (int col = 0; col < M + 1; col++)
                {
                    Console.Write(A[row, col]);
                }
                Console.WriteLine();
            }
            //Forward elimination
            for (int k = 0; k < M; k++)
            {
                for (int i = k + 1; i < M; i++)
                {
                    int factor = A[i, k] / A[k, k];
                    for (int j = k; j < M + 1; j++)
                    {
                        A[i, j] -= factor * A[k, j];
                    }
                }
            }
            //Display Matrix
            for (int row = 0; row < M; row++)
            {
                for (int col = 0; col < M + 1; col++)
                {
                    Console.Write(A[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
