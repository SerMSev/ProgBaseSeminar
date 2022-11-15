/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Ведите количество чисел (М): ");
int m = Convert.ToInt32(Console.ReadLine());

int nextValue = 0;
int result = 0;

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Ведите {i+1} число: ");
    nextValue = Convert.ToInt32(Console.ReadLine());
    if(nextValue > 0 ){result++;}
}

Console.WriteLine($"Из введенных вами чисел ({m}) чисел больше 0 -  {result}");