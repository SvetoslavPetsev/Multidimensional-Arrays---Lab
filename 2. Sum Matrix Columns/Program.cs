using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static int[] ReadArrFromConsole() => Console.ReadLine().Split(SplitSymbol(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        static char[] SplitSymbol() => new char[] { ',', ' ' };
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
            var matrixParam = ReadArrFromConsole();
            var rows = matrixParam[0];
            var cols = matrixParam[1];
            var matrix = new int[rows, cols];
            Fillmatrix(rows, cols, matrix);

            for (int col = 0; col < cols; col++)
            {
                int sumCol = 0;
                for (int row = 0; row < rows; row++)
                {
                    sumCol += matrix[row, col];
                }
                Console.WriteLine(sumCol);
            }
        }
    }
}
