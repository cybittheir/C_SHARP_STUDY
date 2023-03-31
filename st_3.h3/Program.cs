/*
     
     Напишите программу, которая принимает на вход число (N) 
     и выдаёт таблицу кубов чисел от 1 до N.

 */

// принимаем или генерируем число
int Entrance (string greeting)
{
    int result=-1;
    int minNumber=1;
    int maxNumber=20;
    
    while (result>maxNumber || result<0)
    {
        Console.Clear();
        Console.WriteLine(greeting + ":");
        result = int.Parse(Console.ReadLine());
        if (result==0)
        {
            result=new Random().Next(minNumber,maxNumber);
        }
    }

    return result;
}

// основная часть программы
    int N = Entrance("Введите число от 1 до 20 или 0 для случайного");

    string result = "";

    for (int i=1;i<=N;i++){
        if (i!=N)
        {
            // работает и без Convert.ToString но так вроде правильней
            result += Convert.ToString(Math.Pow(i,3)) + ", ";
        }
        else
        {
            result += Convert.ToString(Math.Pow(i,3));
        }
    }

    Console.WriteLine($"Кубы чисел от 1 до {N} -> {result}.");