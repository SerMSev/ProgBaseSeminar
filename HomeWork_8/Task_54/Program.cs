/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Заполнение массива случайными числами и вывод на экран
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Сортировка элементов в строках массива по убыванию значений 
void SortLines(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++) // внешний цикл - по строкам двумерного массива
    {
        for (int j = 0; j < array.GetLength(1); j++) // средний цикл - по столбцам двумерного массива
        {
            for (int k = j + 1; k < array.GetLength(1); k++)  // внутренний цикл - по элементам строки          
            {
                if(array[i,k] > array[i,j])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите количество строк (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (N): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] workArray = new int[m, n];

FillArray(workArray);
SortLines(workArray);

Console.WriteLine();

for (int i = 0; i < workArray.GetLength(0); i++)
{
    for (int j = 0; j < workArray.GetLength(1); j++)
    {
        Console.Write(workArray[i, j] + " ");
    }
    Console.WriteLine();
}
