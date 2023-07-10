void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 101);
        }
    }
}

void SortArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] matrix = new int[row, column];

FillArray(matrix);
Console.WriteLine("Первоначальный массив: ");
PrintArray(matrix);
SortArray(matrix);
Console.WriteLine("Конечный массив: ");
PrintArray(matrix);
