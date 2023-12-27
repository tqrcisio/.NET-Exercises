using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < values.Length; j++)
                {
                    int value = int.Parse(values[j]);
                    matrix[i, j] = value;
                }
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        System.Console.WriteLine($"Position {i},{j}");
                        if (j > 0)
                        {
                            int leftValue = matrix[i, j - 1];
                            System.Console.WriteLine($"Left: {leftValue}");
                        }
                        if (i > 0)
                        {
                            int upValue = matrix[i - 1, j];
                            System.Console.WriteLine($"Up: {upValue}");
                        }
                        if (j < n - 1)
                        {
                            int rightValue = matrix[i, j + 1];
                            System.Console.WriteLine($"Right: {rightValue}");
                        }
                        if (i < m - 1)
                        {
                            int downValue = matrix[i + 1, j];
                            System.Console.WriteLine($"Down: {downValue}");
                        }

                    }
                }
            }
        }
    }
}