void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random st = new Random();
            Random nd = new Random();
            matr[i, j] = st.Next(-100, 101) * nd.NextSingle();
        }
    }
}
Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

double[,] matr = new double[row, column];

FillArray(matr);
PrintArray(matr);
