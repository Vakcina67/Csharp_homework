Console.WriteLine("Введите координату X1: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z1: ");
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
int yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z2: ");
int zb = int.Parse(Console.ReadLine());

double length = Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2);
double res_length = Math.Sqrt(length);

Console.WriteLine($"Расстояние между точками равно {Math.Round(res_length, 2)}");
