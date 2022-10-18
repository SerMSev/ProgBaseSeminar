/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number;
if(number < 99)
{
    Console.WriteLine("третьей цифры нет или число отрицательное");
}
else
{
    while(result > 999)
    {
        result = result / 10;
    }
    result = result % 10;
    Console.WriteLine(result);
}