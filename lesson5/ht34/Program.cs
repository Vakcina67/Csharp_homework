Console.WriteLine("Количество элементов в массиве: ");
int array_length = int.Parse(Console.ReadLine());

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
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
    int even_num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even_num++;
        }
    }
    return even_num;
}

int[] result_array = GenerateArray(array_length);
PrintArray(result_array);
int result_num = MyArray(result_array);
Console.WriteLine($"В массиве {result_num} четных элементов");