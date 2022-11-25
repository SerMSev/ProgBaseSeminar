/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NaturDigit(int n)
{
    if(n == 1)
    {
        Console.Write(n);
        return;
    }
    Console.Write(n + ", ");
    NaturDigit(n - 1);
}

Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

NaturDigit(n);
