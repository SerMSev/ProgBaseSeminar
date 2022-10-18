// Найти максимальное из трех чисел
Console.Write("Введи число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число C: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) { max = b; }

if (c > max) { max = c; }

Console.WriteLine($"Максимальное из трех чисел: {max}");
Console.ReadKey();
