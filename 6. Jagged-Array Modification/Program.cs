using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            var arr = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                var fillRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arr[i] = new int[fillRow.Length];
                for (int j = 0; j < fillRow.Count(); j++)
                {
                    arr[i][j] = fillRow[j];
                }
            }

            string input;
            while ((input = Console.ReadLine().ToLower())!= "end")
            {
                var cmdArgs = input.Split();
                var cmd = cmdArgs[0];
                var row = int.Parse(cmdArgs[1]);
                var col = int.Parse(cmdArgs[2]);
                var number = int.Parse(cmdArgs[3]);
                if (row < 0 || row > rows - 1 || col < 0 || col > arr[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (cmd == "add")
                {
                    arr[row][col] += number;
                }
                else if (cmd == "subtract")
                {
                    arr[row][col] -= number;
                }
            }
            foreach (var row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
