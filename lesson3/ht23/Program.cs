Console.WriteLine("Введите число N: ");
int user_number = int.Parse(Console.ReadLine());

for (int i = 1; i <= user_number; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}