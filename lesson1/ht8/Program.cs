Console.Write("Введите целое положительное число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
string res = $"Четные числа от {count} до {N}: ";

while (count <= N)
{
    if (count % 2 == 0)
    {
        res += $"{count}, ";
    }
    count++;
}
Console.WriteLine(res);