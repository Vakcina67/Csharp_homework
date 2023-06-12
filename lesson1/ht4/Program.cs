Console.Write("Введите первое целое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int number_3 = int.Parse(Console.ReadLine());

if (number_1 > number_2 & number_1 > number_3)
{
    Console.WriteLine($"Максимальное число равно {number_1}");
}
else if (number_2 > number_1 & number_2 > number_3)
{
    Console.WriteLine($"Максимальное число равно {number_2}");
}
else if (number_3 > number_1 & number_3 > number_2)
{
    Console.WriteLine($"Максимальное число равно {number_3}");
}
else
{
    Console.WriteLine("Вы ввели одинаковые числа!");
}