/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным элементов массива
[3 7 22 2 78] -> 76
*/

// Получает на вход массив вещественных чисел и возвращает разницу между минимальным и максимальным
double[] DiffMinMax(double[] array)
{
    double[] result = new double[3] {array[0], array[0], 0}; // массив для хранения результатов {min valua, max value, difference}
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < result[0]) result[0] = array[i];
        if(array[i] > result[1]) result[1] = array[i];
    }
    result[2] = result[1] - result[0];
    return result;
}

// Основная часть программы
Console.Write("Введите количество элементов массива: ");
int array_length = Convert.ToInt32(Console.ReadLine());

double[] arrayWork = new double[array_length]; // создаем рабочий массив
double[] answer = new double[3]; // создаем массив ответов

Console.WriteLine($"Размер массива: {array_length}");
Console.WriteLine("Сам сгенерированный массив:");
for (int i = 0; i < arrayWork.Length; i++)
{
    arrayWork[i] = new Random().NextDouble() * 10;
    Console.Write($"{arrayWork[i]}, ");
}

    answer = DiffMinMax(arrayWork);
    Console.WriteLine();
    Console.Write($"Разница между максимальным числом {answer[1]} и минимальным {answer[0]} равна {answer[2]}");