/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

// Запрос входных данных от пользователя
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второеое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое число больше, второе - меньше");
}
else
{
    if (a < b)
    {
        Console.WriteLine("Первое число меньше, второе - больше");
    }
    else
    {
        Console.WriteLine("Оба числа равны");
    }
    
}