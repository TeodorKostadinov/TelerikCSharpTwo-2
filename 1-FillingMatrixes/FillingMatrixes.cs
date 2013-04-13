using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillingMatrixes
{
    static bool IsTraversable(int[,] matrix, int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1) && matrix[x, y] == 0;
    }
    static int direction = 0;
    static int[,] directions = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };
    static void DFS(int[,] matrix, int row, int col, int current)
    {
        matrix[row, col] = current; 

        if (current == matrix.Length) return; 
        int _row = row + directions[direction, 0];
        int _col = col + directions[direction, 1];

        if (!IsTraversable(matrix, _row, _col)) direction = -1;
        while (!IsTraversable(matrix, _row, _col))
        {
            direction++;
            _row = row + directions[direction, 0];
            _col = col + directions[direction, 1];
        }

        DFS(matrix, _row, _col, current + 1); 
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int[,] matrixC = new int[n, n];
        int[,] matrixD = new int[n, n];
        //A
        int counter = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixA[j, i] = counter;
                counter++;
            }
        }
        //B
        counter = 1;
        for (int i = 0; i < n; i++)
        {
            if(i%2==0)
                for (int j = 0; j < n; j++)
                {
                    matrixB[j, i] = counter;
                    counter++;
                }
            else
                for (int j = n-1; j >=0; j--)
                {
                    matrixB[j, i] = counter;
                    counter++;
                    
                }
        }
        //C
        counter = 1;
        for (int i = 0; i <= n - 1; i++)
            for (int j = 0; j <= i; j++) matrixC[n - i + j - 1, j] = counter++;

        for (int i = n - 2; i >= 0; i--)
            for (int j = i; j >= 0; j--) matrixC[i - j, n - j - 1] = counter++;


        //D
        DFS(matrixD, 0, 0, 1);

        Console.WriteLine("A): ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}    ", matrixA[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("B): ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}    ", matrixB[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("C): ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}   ", matrixC[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("D): ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}    ", matrixD[i, j]);
            }
            Console.WriteLine();
        }
    }
}

