/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Метод - получает на вход 3D-координаты двух точек и возвращает расстояние между ними 
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

}

// Основная программа - запрашивает и получает от пользователя координаты двух точек в 3D печатает результат
Console.WriteLine("Введите координаты первой точки");
Console.Write("      абсцисса: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("      ордината: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("      аппликата: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("      абсцисса: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("      ордината: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("      аппликата: ");
int bz = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance3D(ax,ay,az,bx,by,bz), 2); // Округляем результат до 2-х цифр после запятой

Console.WriteLine($"Расстояние между введенными вами точками: {result}");
