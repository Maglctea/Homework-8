int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = num;
                num += 2;
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}){"",3}");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,,] m1 = CreateMatrixRndInt(3, 4, 3);
PrintMatrix(m1);