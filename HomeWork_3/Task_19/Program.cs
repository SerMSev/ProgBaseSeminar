// Задача №19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//
// Программа работает с числами любой разрадности от 1 до максимально возможной для типа int
// Способ - лобовой - "разворачиваем" число хвостом вперед и сравниваем с введенным. Если равны - палиндром
// (как и требовалось - без применения строк и массивов)



// Метод NumberReverce - получает на вход целое положительное число и возвращает его "отражение" 
 int NumberReverce(int source)
{
    int reverce = 0; // отражение
    int digit; // текущая последняя цифра
    int number = source; // рабочая переменная для текущей не отраженной части числа

    while (number != 0) 
    {
        digit = number % 10;
        reverce = reverce * 10 + digit;
        number = number / 10;
    }
    return reverce;
}

// Метод IsPalindrome - получает на вход целое положительное число и возвращает ИСТИНУ если оно палиндром и ЛОЖЬ - если нет
bool IsPalindrome(int source)
{
    int rev = NumberReverce(source);
    if (rev == source) return true;
    else return false;
}

// Метод IsPositive - получает на вход число и возвращает ИСТИНУ если оно положительное и ЛОЖЬ - если нет
bool IsPositive(int source)
{
    if (source >= 0) return true;
    else return false;
}


// Основная программа - запрашивает и получает от пользователя число, проверяет его на корректность требованиям и сообщает пользователю палиндром ли это
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPositive(number))
{
    if(IsPalindrome(number)) Console.WriteLine("Вы ввели палиндром");
    else Console.WriteLine("Вы ввели НЕ палиндром");
}
else Console.WriteLine("Вы ввели отрицательное число");

