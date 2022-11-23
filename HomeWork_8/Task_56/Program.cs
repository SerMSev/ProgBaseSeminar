/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
 строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
элементов: 1 строка
*/

// Заполнение массива случайными числами и вывод на экран
void FillArray(int[,] array, int maxElement)
{
    Console.WriteLine("Сгенерирован массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, maxElement+1);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Расчет номера строки с нименьшей суммой значений
int LowestSumLine(int[,] array, int maxElement)
{
    int[] tempSum = new int[array.GetLength(0)]; // массив сумм значений по строке
    int minSum = maxElement * array.GetLength(1); // делаем элемент с наименьшим значением заведомо равным максимально большому возможному значению суммы строки 
    int minLine = 0;

    for (int i = 0; i < array.GetLength(0); i++) // внешний цикл - по строкам двумерного массива
    {
        for (int j = 0; j < array.GetLength(1); j++) // средний цикл - по столбцам двумерного массива
        {
            tempSum [i] = tempSum [i] + array[i,j];            
        }

        if(tempSum[i] < minSum)
        {
            minSum = tempSum[i];
            minLine = i;  
        }
//        Console.WriteLine($"строка {i} - сумма {tempSum[i]}");
    }
    return minLine;
}

Console.WriteLine("Введите количество строк (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (N): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное возможное значение элемента массива (E): ");
int e = Convert.ToInt32(Console.ReadLine());

int[,] workArray = new int[m, n];

FillArray(workArray, e);
Console.WriteLine();
int resultLine = LowestSumLine(workArray, e);
Console.WriteLine();
Console.Write($"строка с наименьшей суммой элементов: {resultLine} строка");
Console.WriteLine();
