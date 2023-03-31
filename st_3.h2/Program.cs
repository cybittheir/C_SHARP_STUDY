
/*
    Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве.
*/

 
int [] Entrance (string greeting)
{
    int [] result = new int [3];
    string [] direction = {"X","Y","Z"};

    Console.WriteLine(greeting + ":");
    
    for (int i = 0; i<3; i++ )
    {
        Console.Write(direction[i] + ": ");
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}
    
    Console.Clear();
    
    int [] a = Entrance("Введите координаты первой точки");
    int [] b = Entrance("Введите координаты второй точки");

    double L=Math.Sqrt(Math.Pow(a[0]-b[0],2) + Math.Pow(a[1]-b[1],2) + Math.Pow(a[2]-b[2],2));
    
    Console.WriteLine("=====\nРасстояние между точками в 3D пространстве:");
    Console.WriteLine($"A({a[0]},{a[1]},{a[2]}); B({b[0]},{b[1]},{b[2]}) -> {L:f2}");