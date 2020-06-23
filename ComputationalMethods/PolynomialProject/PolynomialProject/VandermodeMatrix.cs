using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialProject
{
    public class VendermodeMatrix
    {
        public int nRow, nCol;
        public double[,] matrix;
        public CartesianCoordinate _coordinate;

        public VendermodeMatrix(CartesianCoordinate coordinate)
        {
            _coordinate = coordinate;
            nRow = _coordinate.coordinatesList.Count;
            nCol = nRow + 1;
            matrix = new double[nRow, nCol];
        }

        public void SetMatrix()
        {
            int exponent = nRow - 1;
            for (int i = 0; i < nRow; i++)
            {
                double x = _coordinate.coordinatesList[i].x;
                double y = _coordinate.coordinatesList[i].y;
                for (int j = 0; j < nCol; j++)
                {
                    if (j == nCol - 2)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == nCol - 1)
                    {
                        matrix[i, j] = y;
                    }
                    else
                    {
                        matrix[i, j] = Math.Pow(x, exponent);
                    }
                    exponent--;
                }
                exponent = _coordinate.coordinatesList.Count() - 1;
            }
        }

        public double[,] GetMatrix()
        {
            return this.matrix;
        }

        public void DisplayMatrix()
        {
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}