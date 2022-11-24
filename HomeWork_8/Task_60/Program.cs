/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void CreateRandomArray(int[,,] array)
{
/* Неповторяющихся двузначных чисел может быть только 100 штук. Поэтому мы можем заранее сгенерировать массив всех
подходящих нам чисел и затем заполнять рабочий массив уже выбирая случайным образом из готового
Вторую размерность случайного списка будем использовать для технических целей: 0 - уже использовали, 
1 - заполнено или можно использовать
*/
    int[,] tempRandom = new int[99, 99]; // массив двузначных чисел от 01 до 99
    for (int i = 0; i < 99; i++)
    {
        tempRandom[i, 0] = i + 1;
        tempRandom[i, 1] = 1;
    }
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                // ищем еще не использованное двузначное число в массиве tempRandom
                
                Random rnd = new Random();
                int indRand = Convert.ToInt32(1 + rnd.NextDouble() * 98);

                //  Console.WriteLine($"{indRand}  {tempRandom[indRand, 1]}  {tempRandom[indRand, 0]}");
                //  Console.ReadLine();      

                while(tempRandom[indRand, 1] == 0)
                {
                    indRand = Convert.ToInt32(1 + rnd.NextDouble() * 98);
                    // Console.WriteLine($"{indRand}  {tempRandom[indRand, 1]}  {tempRandom[indRand, 0]}");
                    // Console.ReadLine();
                }
                // отмечаем число как использованное и
                // заполняем очередную ячейку рабочей матрицы
                tempRandom[indRand, 1] = 0;
                array[x, y, z] = tempRandom[indRand, 0];
                // Console.ReadLine();
            }
        }
    }

}

Console.WriteLine();
Console.WriteLine("Вводим исходные измерения матрицы ");
Console.Write("Введите количество строк (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (N): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите плоскостей (P): ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(m * n * p > 99)
{
    Console.WriteLine("Т.к. двузначных неповторяющихся значений может быть только 99, то общее количество");
    Console.WriteLine("элементов трехмерного массива не должно быть больше 99! Выберите другие измерения");
}
else
{
    int[,,] workArray = new int[m, n, p];

    CreateRandomArray(workArray);
// Вывод результатов
    Console.WriteLine($"Матрица размером - {m} х {n} х {p}");
    for (int k = 0; k < workArray.GetLength(2); k++)
    {
        for (int i = 0; i < workArray.GetLength(0); i++)
        {
            for (int j = 0; j < workArray.GetLength(1); j++)
            {
                Console.Write($"{workArray[i,j,k]}({i}, {j}, {k})  ");  
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
