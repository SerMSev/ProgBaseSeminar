/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return (A(m - 1, A(m, n - 1)));
    }
}

Console.WriteLine();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(n >= 0 || m >= 0)
{
    int result = A(m, n);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Функция Аккермана определена только для неотрицательных чисел");
}

Console.WriteLine();
