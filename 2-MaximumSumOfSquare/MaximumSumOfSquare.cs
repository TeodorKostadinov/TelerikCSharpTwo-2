using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaximumSumOfSquare
    {
        static void Main(string[] args)
        {
            var maxSumij = new int[2];
            var maxSum = int.MinValue;
            Console.WriteLine("Enter matrix width");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ënter matrix height");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter matrix elements");
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter element {0}-{1} ",i,j);
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i <= m - 3; i++)
            {
                for (int j = 0; j <= n - 3; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < 3; k++)
                        for (int l = 0; l < 3; l++)
                            sum += matrix[i + k, j + l];
                    if (sum > maxSum)
                    {
                        maxSumij[0] = i;
                        maxSumij[1] = j;
                        maxSum = sum;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The max sum is {0} and the square is ",maxSum);
            for (int i = maxSumij[0]; i < maxSumij[0]+3; i++)
            {
                for (int j = maxSumij[1]; j < maxSumij[1]+3; j++)
                {
                    Console.Write("{0} ",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }

