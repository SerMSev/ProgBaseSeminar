/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
*/

// Получает на вход массив целых трехзначные чисел и возвращает количество четных
int CountEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) result ++;
    }
    return result;
}

// Основная часть программы
Console.Write("Введите количество элементов массива: ");
int array_length = Convert.ToInt32(Console.ReadLine());

int[] arrayWork = new int[array_length]; // создаем рабочий массив

Console.WriteLine($"Размер массива: {array_length}");
Console.WriteLine("Сам сгенерированный массив:");
for (int i = 0; i < arrayWork.Length; i++)
{
    arrayWork[i] = new Random().Next(100, 1000);
    Console.Write($"{arrayWork[i]}, ");
}

    Console.WriteLine();
    Console.Write($"В нем имеется {CountEven(arrayWork)} четных чмсел");
