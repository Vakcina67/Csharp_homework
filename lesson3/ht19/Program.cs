Console.WriteLine("Введите пятизначное число: ");
int num_1 = int.Parse(Console.ReadLine());

if (num_1 > 9999 && num_1 < 100000)
{
    int num_2 = (num_1 % 10) * 10000 + (num_1 / 10 % 10) * 1000 + (num_1 / 100 % 10) * 100 +
    (num_1 / 1000 % 10) * 10 + num_1 / 10000 % 10;
    if (num_2 == num_1)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели некорректное число!");
}
