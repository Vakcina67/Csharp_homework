int SumRec(int a, int b)
{
    if (a == b) return a;
    else return a + SumRec(a + 1, b);
}


Console.WriteLine("Введите число M:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число не может быть больше второго!");
    return;
}
Console.WriteLine(SumRec(num1, num2));
