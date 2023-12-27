using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int matrixIndex = 0; matrixIndex < n; matrixIndex++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int valueIndex = 0; valueIndex < values.Length; valueIndex++)
                {
                    int value = int.Parse(values[valueIndex]);
                    matrix[matrixIndex, valueIndex] = value;
                }
            }

            System.Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(matrix[i, i] + " ");
            }


            int countNegative = 0;
            for (int x = 0; x < n; x++)
                for (int y = 0; y < n; y++)
                {
                    if (matrix[x, y] < 0)
                    {
                        countNegative++;
                    }
                }
            System.Console.WriteLine("Negative numbers = " + countNegative);
        }
    }
}