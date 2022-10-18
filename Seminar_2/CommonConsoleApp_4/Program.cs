/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.Write("Введи число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int remainder = a % b;
if(remainder == 0) 
{
    Console.WriteLine($"Число {b} кратно числу {a}");

}
else
{
    Console.WriteLine($"Число {b} не кратно числу {a}, остаток от деления {remainder}");
}

