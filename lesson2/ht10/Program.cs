Console.Write("Введите трехзначное число: ");
int number_1 = int.Parse(Console.ReadLine());

if (number_1 < 100 || number_1 >= 1000)
{
    Console.WriteLine("Вы ввели некорректное число!");
}
else
{
    Console.WriteLine($"Вторая цифра цисла равна {number_1 / 10 % 10}");
}