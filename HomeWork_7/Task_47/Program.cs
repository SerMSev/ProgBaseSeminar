/* Задача 47. Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). Округлите значения, генерируемые Random до двух
 знаков после запятой.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void FillArray(double[,] array) // метод для заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Генерируем случайные вещественные числа в дапазоне -10.13..9.79 и заполняем ими массив
            Random rnd = new Random();
            array[i, j] = Math.Round(-10.13 + rnd.NextDouble() * (9.79 + 10.13), 2);
        }
    }
}

void PrintArray(double[,] array) // метод для вывода массива на экран терминала
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]},  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
