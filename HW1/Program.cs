/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int[] array = int num;

if (palindrom(num))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


bool palindrom(int[] array)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        return true;
    }
    return false;
}
