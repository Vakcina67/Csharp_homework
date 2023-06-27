Console.WriteLine("Количество элементов в массиве: ");
int array_length = int.Parse(Console.ReadLine());

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-999, 1000);
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

int MyArray(int[] array)
{
    int odd_sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            odd_sum = odd_sum + array[i];
        }
    }
    return odd_sum;
}

int[] result_array = GenerateArray(array_length);
PrintArray(result_array);
int result_num = MyArray(result_array);
Console.WriteLine($"Сумма нечетных элементов равна {result_num}");
