/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string num = (Console.ReadLine());

if (num.Length > 5)
{
    Console.WriteLine("Ошибка. Введите пятизначное число");
}
else if (palindrom(num))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


bool palindrom(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        return true;
    }
    return false;
}
