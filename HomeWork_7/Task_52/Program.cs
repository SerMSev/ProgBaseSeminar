/* Задача 52. Запросите от пользователя размерности двумерного массива. Напишите метод для 
заполнения массива случайными числами. Напишите метод для поиска ср. арифметического значения 
каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void FillArray(int[,] array) // метод для заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Генерируем случайные целые числа в дапазоне 1..9, заполняем ими массив и выводим его на экран
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticalMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result[j] = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[j] = result[j] + array[i, j];
            
        }
        result[j] = Math.Round(result[j] / array.GetLength(0), 2);
        Console.Write($"{result[j]} \t ");
    }
    return result;
}


Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
ArithmeticalMean(array);
