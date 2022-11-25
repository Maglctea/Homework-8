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

int[,] SortRowMatrix(int[,] matrix, int rowNumber)
{
    int bufer;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowNumber, j - 1] < matrix[rowNumber, j])
            {
                bufer = matrix[rowNumber, j];
                matrix[rowNumber, j] = matrix[rowNumber, j - 1];
                matrix[rowNumber, j - 1] = bufer;
            }
        }
    }
    return matrix;
}

int[,] m = CreateMatrixRndInt(4, 5, 0, 10);
Console.WriteLine("Стартовый массив:");
PrintMatrix(m);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < m.GetLength(0); i++)
{
    SortRowMatrix(m, i);
}
PrintMatrix(m);

