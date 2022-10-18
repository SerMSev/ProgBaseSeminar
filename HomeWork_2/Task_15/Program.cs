/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите номер дня недели(от 1 до 7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber < 1 | dayNumber > 7)
{
    Console.WriteLine("Дня недели с таким номером не бывает");
}
else
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да, выходной");
    }
    else
    {
        Console.WriteLine("Нет, будний день");
    }
   
}