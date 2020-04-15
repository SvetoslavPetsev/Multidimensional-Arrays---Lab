using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static char[] ReadArrFromConsole() => Console.ReadLine().ToCharArray();
        private static void Fillmatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                var rowInput = ReadArrFromConsole();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
        }
        static void Main()
        {
            var matrixParam = int.Parse(Console.ReadLine());
            var matrix = new int[matrixParam, matrixParam];
            Fillmatrix(matrixParam, matrixParam, matrix);
            var symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrixParam; row++)
            {
                for (int col = 0; col < matrixParam; col++)
                {
                    var element = matrix[row, col];
                    if (element == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
