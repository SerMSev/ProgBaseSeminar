/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите целое число A:");
int user_value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B:");
int user_power = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = 1;

for (int i = 1; i <= user_power; i++)
{
    result = result * user_value;
}

Console.WriteLine(result);

