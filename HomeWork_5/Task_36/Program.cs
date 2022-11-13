/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Получает на вход массив целых чисел и возвращает сумму чисел на нечетных позициях
int SumOddPosition(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        result = result + array[i];
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
    arrayWork[i] = new Random().Next(1, 100);
    Console.Write($"{arrayWork[i]}, ");
}

    Console.WriteLine();
    Console.Write($"Сумма чисел на нечетных позициях в нем равна {SumOddPosition(arrayWork)}");