Console.WriteLine("Количество элементов в массиве: ");
int array_length = int.Parse(Console.ReadLine());

Console.WriteLine("Начальное значение для диапазона: ");
int num_min = int.Parse(Console.ReadLine());

Console.WriteLine("Конечное значение для диапазона: ");
int num_max = int.Parse(Console.ReadLine());

int[] Random_array(int array_length, int min, int max)
{
    int[] array = new int[array_length];
    Random random = new Random();
    for (int i = 0; i < array_length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ");
    Console.WriteLine("]");
}
int[] array = Random_array(array_length, num_min, num_max);
PrintArray(array);
