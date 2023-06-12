Console.Write("Введите целое число: ");
int number_1 = int.Parse(Console.ReadLine());

if (number_1 % 2 == 0)
{
    Console.WriteLine($"Число {number_1} четное");
}
else
{
    Console.WriteLine($"Число {number_1} нечетное");
}