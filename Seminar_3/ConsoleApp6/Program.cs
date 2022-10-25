/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причем X и Y не равны 0
и выдает номер квадранта в которой она находится (1(++)2(-+)3(--)4(+-)
*/
int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if(coordX > 0 && coordY > 0)
    {
        numberArea = 1;
    }

    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }

    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }

    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }

    return numberArea;
}

int GetPointAreaShorter(int coordX, int coordY)

    if (coordX > 0 && coordY > 0)
    {
        return 1;
    }

    if (coordX < 0 && coordY > 0)
    {
        return 2;
    }

    if (coordX < 0 && coordY < 0)
    {
        return 3;
    }

    if (coordX > 0 && coordY < 0)
    {
        returna = 4;
    }

    return 0;
}

Console.WriteLine("Введи X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);
