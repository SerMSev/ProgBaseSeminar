/* Задача 22: Напишите прогу, которая принимает на вход 
 * число (N) и выдает таблицу квадратов чисел от 1 до N
 * 5 -> 1,4,9,16,25
 * 2 -> 1,4
 * без матриц
 */
void PrintSquareToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i);
    } 
}

PrintSquareToConsole(10);
