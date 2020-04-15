using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            var arrParam = int.Parse(Console.ReadLine());
            var jagArr = new long[arrParam][];
            for (int row = 0; row < arrParam; row++)
            {
                jagArr[row] = new long[row + 1];
                var cols = row + 1;
                for (int col = 0; col < cols; col++)
                {
                    if (col == 0 || col == cols - 1)
                    {
                        jagArr[row][col] = 1;
                    }
                    else
                    {
                        jagArr[row][col] = jagArr[row - 1][col - 1] + jagArr[row - 1][col];
                    }
                }
            }
            foreach (var row in jagArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
