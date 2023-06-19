Console.Write("Введите целое число: ");
int number_1 = int.Parse(Console.ReadLine());

while (number_1 > 999)
{
    number_1 = number_1 / 10;
}

if (number_1 < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write($"Третья цифра числа равна {number_1 % 10}");
}