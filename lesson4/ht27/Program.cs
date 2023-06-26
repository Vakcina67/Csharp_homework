Console.WriteLine("Введите число: ");
int number_1 = int.Parse(Console.ReadLine());

int Sum_digits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр в числе равна {Sum_digits(number_1)}");
