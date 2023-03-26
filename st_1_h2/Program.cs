// Get how many numbers use in comparing

Console.Clear();
int maxNum=8;
Console.Write("Сколько чисел сравниваем (2-{0:D}): ",maxNum);

// Testing validate of input while it will be correct

int count =1; // initialize 'count' with value less then range allows

while (count<2||count>maxNum)
{
    count=int.Parse(Console.ReadLine());
    if (count<2||count>5)
    {
        Console.Write("Ошибка. Повторите ввод: ");
    }
}

// getting numbers for comparing

int [] compare =new int[count];

for (int i=0;i<count;i++)
{
    Console.Write($"Введите число №{i+1}: ");
    compare[i]=int.Parse(Console.ReadLine());
}

// preparing for comparing

int max;
int min;

if (compare[0]>compare[count-1])
{
        max=compare[0];
        min=compare[count-1];
} 
else 
{
        min=compare[0];
        max=compare[count-1];
}

// find MAX and MIN values

string numbers="";

for (int i=0;i<count;i++)
{
    if (compare[i]>max)
    {
        max=compare[i];
    }
    else if (compare[i]<min)
    {
        min=compare[i];
    }
    if (i<count-1)
    {
        numbers+=compare[i].ToString()+",";
    }
    else
    {
        numbers+=compare[i].ToString();
    }
}

// Selecting odds numbers from the range of MIN and MAX

string odds="";

for (int j=min;j<=max;j++)
{
    if (j%2==0 && odds=="")
    {
        odds=j.ToString();
    }
    else if (j%2==0)
    {
        odds+=", "+j.ToString();
    }
}

// Printing all results

Console.WriteLine("Числа: " + numbers);
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Максимум: {max}");
Console.WriteLine($"Все четные числа между крайними значениями(включая их): {odds}");
