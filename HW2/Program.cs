/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

Console.WriteLine("Введите координату X1 ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1 ");
int a2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z1");
int a3 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2 ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2 ");
int b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z2");
int b3 = int.Parse(Console.ReadLine());


Console.WriteLine("Длина отрезка равна "+ Math.Round(getLength(b1, a1, b2, a2, b3, a3), 2));

double getLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double Distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return Distance;
}