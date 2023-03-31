// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);


Console.Clear();

Console.WriteLine("X1:");
double ax=double.Parse(Console.ReadLine());
Console.WriteLine("Y1:");
double ay=double.Parse(Console.ReadLine());
Console.WriteLine("X2:");
double bx=double.Parse(Console.ReadLine());
Console.WriteLine("Y2:");
double by=double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(ax - bx,2) + Math.Pow(ay - by,2));
Console.WriteLine(Math.Sqrt(Math.Pow(ax - bx,2) + Math.Pow(ay - by,2)));

Console.WriteLine($"d={d:f3}"); // f3 - количество знаков после запятой

