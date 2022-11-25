int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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


int GetMatrixNumber(int[,] matrix1, int[,] matrix2, int x, int y)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) return -1;

    int sum = 0;
    for (int position = 0; position < matrix1.GetLength(1); position++)
    {
        sum += matrix1[x, position] * matrix2[position, y];
    }
    return sum;
}


void MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Произведение невозможно");
        return;
    }
    else
    {
        int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int row = 0; row < newMatrix.GetLength(0); row++)
        {
            for (int column = 0; column < newMatrix.GetLength(1); column++)
            {
                newMatrix[row, column] = GetMatrixNumber(matrix1, matrix2, row, column);
            }
        }

        PrintMatrix(newMatrix);
    }

}


int[,] m1 = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine("Матрица 1:");
PrintMatrix(m1);
Console.WriteLine();
int[,] m2 = CreateMatrixRndInt(4, 2, 1, 10);
Console.WriteLine("Матрица 2:");
PrintMatrix(m2);
Console.WriteLine("\nРезультат произведения матриц:");
MultiplyMatrix(m1, m2);