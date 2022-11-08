/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];

int num = 0;

for (int i = 0; i <= 7; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}