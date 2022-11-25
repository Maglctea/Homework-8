﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


int SumRowMatrix(int[,] matrix, int rowNumber)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[rowNumber, i];
    }
    return sum;
}


int GetMinRowPosition(int[,] matrix)
{
    int minRow = SumRowMatrix(matrix, 0);
    int minRowPosition = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SumRowMatrix(matrix, i) < minRow)
        {
            minRow = SumRowMatrix(matrix, i);
            minRowPosition = i;
        }
    }
    return minRowPosition + 1;
}


int[,] m = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(m);


Console.WriteLine($"Наименьшая сумма элементов в {GetMinRowPosition(m)} строке");

