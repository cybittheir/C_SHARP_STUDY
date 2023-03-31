// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.Clear();

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

Console.Write(N + " -> ");

int [] result = new int[N];

for (int i=1;i<N+1;i++)
{
    if (i==N)
    {
        Console.Write(Math.Pow(i,2) + ".");
    } else {
        Console.Write(Math.Pow(i,2) + ", ");
    }
    
    result[i-1]=Convert.ToInt32(Math.Pow(i,2));

}

int j=1;

Console.Write("\n" + N + " -> ");

while (j<N+1)
{

    if (j==N)
    {
       Console.Write(Math.Pow(j,2) + ".");
    } else {
        Console.Write(Math.Pow(j,2) + ", ");
    }


    j++;

}

Console.WriteLine("\nчерез массив и foreach:");

foreach (double x in result) 
{
        Console.Write(x + " ");
}