Console.Write("Введите цифру, обозначающую день недели: ");
int number_1 = int.Parse(Console.ReadLine());

if (number_1 > 0 && number_1 <= 5)
{
    Console.WriteLine("Это рабочий день");
}
else if (number_1 == 6 || number_1 == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это не день недели!");
}