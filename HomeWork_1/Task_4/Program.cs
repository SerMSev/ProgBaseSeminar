/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел */

// Ввод исходных данных
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

/* Первый вариант решения - классический вариант 
с одной дополнительной(4-ой) переменной */
int max = a;
if (b > a) max = b;
if (c > max) max = c;
Console.WriteLine(max);


