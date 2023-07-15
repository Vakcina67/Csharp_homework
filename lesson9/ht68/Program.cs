int FuncAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n != 0 & m == 0) return FuncAkkerman(n - 1, 1);
    else return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
}

Console.WriteLine("Введите число M:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int num2 = int.Parse(Console.ReadLine());

if (num1 < 0 || num2 < 0)
{
    Console.WriteLine("Вы ввели отрицательные числа!");
    return;
}

Console.WriteLine(FuncAkkerman(num1, num2));