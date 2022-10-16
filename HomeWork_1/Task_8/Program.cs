/* Задача 8: Напишите программу, которая на вход
принимает положительное целое число (N), а на выходе 
показывает все чётные числа от 1 до N */

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int index = 2;
while(index <= n)
{
    Console.WriteLine(index);
    index = index + 2;
}