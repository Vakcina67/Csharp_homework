Console.Write("Введите первое целое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine($"Большее число {number_1}, меньшее число {number_2}");
}
else if (number_2 > number_1)
{
    Console.WriteLine($"Большее число {number_2}, меньшее число {number_1}");
}
else
{
    Console.WriteLine("Вы ввели одинаковые числа!");
}