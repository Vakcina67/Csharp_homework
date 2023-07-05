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
            matr[i, j] = new Random().Next(-100, 101);
        }
    }
}

double[] MeanColumn(int[,] matr)
{
    int[] sum_column = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum_column[j] += matr[i, j];
        }
    }
    double[] Mean_array = sum_column.Select(x => Convert.ToDouble(x)).ToArray();
    for (int i = 0; i < Mean_array.Length; i++)
    {
        Mean_array[i] = Mean_array[i] / matr.GetLength(1);
    }
    return Mean_array;
}

void PrintResult(double[] matr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{Math.Round(matr[i], 1)}, ");
    }
    Console.WriteLine();
}

Console.WriteLine("Количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] matrix = new int[row, column];

FillArray(matrix);
PrintArray(matrix);
MeanColumn(matrix);
PrintResult(MeanColumn(matrix));
