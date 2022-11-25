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


void GoRight(ref int[,] matrix, ref int currentX, ref int currentY, int step, ref int count)
{
    for (int i = 0; i < step; i++)
    {
        matrix[currentY, currentX] = count + i;
        currentX++;
    }
    count += step - 1;
    currentX--;
}


void GoLeft(ref int[,] matrix, ref int currentX, ref int currentY, int step, ref int count)
{
    for (int i = 0; i < step; i++)
    {
        matrix[currentY, currentX] = count + i;
        currentX--;
    }
    count += step - 1;
    currentX++;
}


void GoUp(ref int[,] matrix, ref int currentX, ref int currentY, int step, ref int count)
{
    for (int i = 0; i < step; i++)
    {
        matrix[currentY, currentX] = count + i;
        currentY--;
    }
    count += step - 1;
    currentY++;
}


void GoDown(ref int[,] matrix, ref int currentX, ref int currentY, int step, ref int count)
{
    for (int i = 0; i < step; i++)
    {
        matrix[currentY, currentX] = count + i;
        currentY++;
    }
    count += step - 1;
    currentY--;
}


Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];
int currentX = 0;
int currentY = 0;
int count = 1;
int step = n;
GoRight(ref matrix, ref currentX, ref currentY, step, ref count);
for (int i = 0; i < n * 2 - 2; i++)
{
    GoDown(ref matrix, ref currentX, ref currentY, step, ref count);
    GoLeft(ref matrix, ref currentX, ref currentY, step, ref count);
    step -= 1;
    GoUp(ref matrix, ref currentX, ref currentY, step, ref count);
    GoRight(ref matrix, ref currentX, ref currentY, step, ref count);
    step -= 1;
}
PrintMatrix(matrix);

