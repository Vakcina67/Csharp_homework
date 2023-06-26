Console.WriteLine("Введите число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите показатель степени: ");
int number_2 = int.Parse(Console.ReadLine());
if (number_2 < 0)
{
    Console.WriteLine("Показатель не должен быть отрицательным!");
    return;
}

int MathPow(int arg1, int arg2)
{
    int start_num = 1;
    for (int i = 0; i < arg2; i++)
    {
        start_num = start_num * arg1;
    }
    return start_num;
}

Console.WriteLine(MathPow(number_1, number_2));