/* Задача 21: Напишите прогу, которая принимает на вход 
 * координаты двух точек в дву-мерном пространстве и
 * находит расстояние между ними.
 * A(3,6);B(2,1) -> 5,09
 * A(7,-5);B(1,-1) -> 7,21
 * 
 * базовая формула: кв.корень из суммы квадратов разниц 
 * 2D double = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2))
 * 3D double = Sqrt(Sq(x2-x1, 2)+Sq(y2-y1,2)+Sq(z2-z1,2))
 * абсцисса, ордината, аппликата
 */

double Distance2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  
}


Console.WriteLine("Введи абсциссу точки A: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи ординату точки A: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи абсциссу точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи ординату точки B: ");
int by = Convert.ToInt32(Console.ReadLine());

double dystanceAB = Distance2D(ax, bx, ay, by);
Console.WriteLine($"Расстояние между точками B и А : {dystanceAB}");

