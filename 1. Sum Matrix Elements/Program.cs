using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
    static int[] ReadArrFromConsole() => Console.ReadLine().Split(SplitSymbol(),StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    static char[] SplitSymbol() => new char[] { ',', ' ' };
    static void Main()
        {
            int[] matrixParam = ReadArrFromConsole();
            int rows = matrixParam[0];
            int cols = matrixParam[1];
            int[,] matrix = new int[rows, cols];
            int sumElements = 0;
            for (int row = 0; row < rows; row++)
            {
                var rowArr = ReadArrFromConsole();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowArr[col];
                    sumElements += rowArr[col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sumElements);
        }
    }
}
