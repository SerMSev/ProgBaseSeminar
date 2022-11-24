/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void FillArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1)) // проверяем все ли элементы заполнены
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else
        {   if (i < j && i + j >= array.GetLength(0) - 1)
            {
                i++;
            }
            else
            {   
                if (i >= j && i + j > array.GetLength(1) - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
        }
    }

}

void OutputArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] / 10 == 0)
        {
            Console.Write($" {array[i,j]} ");
        }
        else 
        {
            Console.Write($"{array[i,j]} ");
        }
    }
    Console.WriteLine();
  }
}

Console.WriteLine();
Console.WriteLine("Введите количество строк и столбцов квадратного масства от 0 до 9 ");
Console.Write("Больше - тоже работает, но некрасиво, надо оптимизировать (но лень): ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
Console.WriteLine();

int[,] workArray = new int[m, n];

FillArray(workArray);
OutputArray(workArray);
Console.WriteLine();
