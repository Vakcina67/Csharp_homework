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

int FindNumber(int[,] matr)
{
    int[] newArray = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum_row = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum_row += matr[i, j];
        }
        newArray[i] = sum_row;
    }
    int min_num = newArray[0];
    for (int k = 1; k < newArray.Length; k++)
    {
        if (newArray[k] < min_num)
        {
            min_num = newArray[k];
        }
    }
    int res_row = new int();
    for (int l = 0; l < newArray.Length; l++)
    {
        if (newArray[l] == min_num)
        {
            res_row = l;
        }
    }
    return res_row + 1;
}

Console.WriteLine("Необходимо получить прямоугольную матрицу");
Console.WriteLine("Количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

if (row == column)
{
    Console.WriteLine("Матрица квадратная!");
    return;
}

int[,] matrix = new int[row, column];

FillArray(matrix);
Console.WriteLine("Первоначальный массив: ");
PrintArray(matrix);

Console.WriteLine($"строка номер {FindNumber(matrix)}");
