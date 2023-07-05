
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

int MatrixElement(int row_coord, int column_coord, int[,] matr)
{
    return matr[row_coord - 1, column_coord - 1];
}

Console.WriteLine("Количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] matrix = new int[row, column];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите номер строки: ");
int x_coord = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int y_coord = int.Parse(Console.ReadLine());

if (x_coord > matrix.GetLength(0) || y_coord > matrix.GetLength(1))
{
    Console.WriteLine("Вы ввели некорректные координаты!");
    return;
}

Console.WriteLine(MatrixElement(x_coord, y_coord, matrix));