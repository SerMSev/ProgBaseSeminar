/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// Заполнение массива случайными числами и вывод на экран
void FillArray(int[,] array, int maxElement)
{
//    Console.WriteLine("Сгенерирован массив: ");
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

// Перемножение двух совместных матриц
void MatrixMultiplication(int[,] array1, int[,] array2, int[,] result)
{

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i,k] * array2[k,j];
            }
            
            result[i,j] = sum;
            Console.Write(result[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

// основной модуль
Console.WriteLine("Вводим исходные матрицы ");
Console.WriteLine("Введите количество строк первой матрицы (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы ");
Console.WriteLine("оно же будет количеством строк второй матрицы (N): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы (P): ");
int p = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное возможное значение элемента матриц (E): ");
int e = Convert.ToInt32(Console.ReadLine());


int[,] workArray1 = new int[m, n]; 
int[,] workArray2 = new int[n, p];

int[,] resultArray = new int[workArray1.GetLength(0), workArray2.GetLength(1)];

Console.WriteLine();
Console.WriteLine("Генерируем первую матрицу: ");
FillArray(workArray1, e);
Console.WriteLine("Генерируем вторую матрицу: ");
FillArray(workArray2, e);
Console.WriteLine();

Console.WriteLine("Произведение указанных матриц: ");
MatrixMultiplication(workArray1, workArray2, resultArray);
Console.WriteLine();
