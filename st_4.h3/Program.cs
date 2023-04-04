/*
    Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
    и выводит их на экран.
    
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33]
*/

//генератор массива длины lenArray из чисел от 1 до dig
int [] genMyArray(int lenArray, int dig)
{
    int [] resultArray = new int [lenArray];
    Random myRandom = new Random();

    for (int i = 0; i < lenArray; i++)
    {
        resultArray[i] = myRandom.Next(1,dig);
    }

    return resultArray;
}

//преобразование списка элементов массива array в строку через разделитель delim
string myImplode(string delim,int[] array)
{
    string result = "";

    for (int i = 0; i < array.Length; i++)
    {
        
        if (i!=array.Length-1)
        {
            result += array[i].ToString() + delim;
        }
        else 
        {
            result += array[i].ToString();
        }
    }
    return result;
}

// выбор разделителей из заранее предложенных
string chooseDelim(string prompt, string []choose)
{
    Console.WriteLine($"{prompt}: ");

    for (int i=1;i<choose.Length;i++)
    {
        Console.WriteLine($"'{choose[i]}' - {i}");
    }
    
    Console.WriteLine($"'{choose[0]}' - любая другая цифра");

    int choise = int.Parse(Console.ReadLine());

    if ( choise==0 || choise>=choose.Length) 
    {
        return choose[0];
    } 
    else 
    {
        return choose[choise];
    }

}

Console.Clear();

string prompt = "Выберите разделитель";
string [] choose = {",",";",":","*","#",".","|"};

Console.WriteLine($"[{myImplode(chooseDelim(prompt,choose),genMyArray(8,100))}]");
