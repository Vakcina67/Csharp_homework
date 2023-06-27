Console.WriteLine("Количество элементов в массиве: ");
int array_length = int.Parse(Console.ReadLine());

double[] GenerateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i}-й элемент массива ");
        array[i] = double.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ");
    Console.WriteLine("]");
}

double find_max(double[] array)
{
    double max_num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max_num)
        {
            max_num = array[i];
        }
    }
    return max_num;
}

double find_min(double[] array)
{
    double min_num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min_num)
        {
            min_num = array[i];
        }
    }
    return min_num;
}

double[] result_array = GenerateArray(array_length);
PrintArray(result_array);
Console.WriteLine($"{find_max(result_array)} - {find_min(result_array)} = {find_max(result_array) - find_min(result_array)}");