string NumberRec(int a)
{
    if (a >= 1) return $"{a} " + NumberRec(a - 1);
    else return String.Empty;
}
Console.WriteLine("Введите начальное число N:");
int numN = int.Parse(Console.ReadLine());

Console.WriteLine(NumberRec(numN));
