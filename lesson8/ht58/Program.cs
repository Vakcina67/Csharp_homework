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
            matr[i, j] = new Random().Next(0, 11);
        }
    }
}

int[,] MultiMatrix(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) != matr2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] res = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                res[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return res;
}

Console.WriteLine("Количество строк в первой матрице: ");
int row1 = int.Parse(Console.ReadLine());

Console.WriteLine("Количество столбцов в первой матрице: ");
int column1 = int.Parse(Console.ReadLine());

Console.WriteLine("Количество строк во второй матрице: ");
int row2 = int.Parse(Console.ReadLine());

Console.WriteLine("Количество столбцов во второй матрице: ");
int column2 = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[row1, column1];
int[,] matrix2 = new int[row2, column2];

FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);

Console.WriteLine("Новая матрица: ");
PrintArray(MultiMatrix(matrix1, matrix2));