/* Задача 18. Напишите программу, которая по
 * заданному номеру четверти, показываеь диапазон
 * возможных координат точек в этой четверти (x и y) */

string CoordRange(int quardrant_number)
{
    if(quardrant_number < 1 || quardrant_number > 4) return "ошибка";
    if(quardrant_number == 1) return "x>0 and y>0";
    if(quardrant_number == 2) return "x<0 and y>0";
    if(quardrant_number == 3) return "x<0 and y<0";
    return "x>0 and y<0";
}


string quadrant_range = "";
Console.WriteLine("Введите номер четверти:");
int user_input = Convert.ToInt32(Console.ReadLine());
quadrant_range = CoordRange(user_input);
Console.WriteLine(quadrant_range);
