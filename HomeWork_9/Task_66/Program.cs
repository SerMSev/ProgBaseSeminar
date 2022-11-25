/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NaturDigit(int m, int n)
{
    if(m == n)
    {
        return n;
    }
    return m + NaturDigit(m + 1, n);
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < m)
{
    int temp = n;
    n = m;
    m = temp;
}


int result = NaturDigit(m, n);
Console.WriteLine(result);