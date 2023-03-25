void GenerateList(int [] compare){

    // getting numbers for comparing
    int count=compare.Length;
    int i;

    for (i=0;i<count;i++)
    {
        compare[i]=new Random().Next(-30,30);
    }

}

string getOdds(int[]edges){
// Selecting odds numbers from the range of MIN and MAX

    int i;
    string odds="";

    int min=edges[0];
    int max=edges[1];

    for (i=min;i<=max;i++)
    {
        if (i%2==0 && odds=="")
        {
            odds=i.ToString();
        }
        else if (i%2==0)
        {
            odds+=", "+i.ToString();
        }
    }
    return odds;
}

int[] Compare(int[] compare){

    int [] edgeValues = new int[2];
    // preparing for comparing
    int count=compare.Length;

    int max;
    int min;
    int i;

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

    string numbersList="";

    for (i=0;i<count;i++)
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
            numbersList+=compare[i].ToString()+",";
        }
        else
        {
            numbersList+=compare[i].ToString();
        }
    }
    
    Console.WriteLine("Числа: " + numbersList);
    
    edgeValues[0]=min;
    edgeValues[1]=max;
    
    return edgeValues;

}

// Staring
// Get how many numbers use in comparing

int maxCount=10;
Console.Clear();
Console.Write("Сколько чисел сравниваем (2-{0:D}): ",maxCount);

// Testing validate of input while it will be correct

int count =1; // initialize 'count' with value less then range allows

while (count<2||count>maxCount)
{
    count=int.Parse(Console.ReadLine());
    if (count<2||count>maxCount)
    {
        Console.Write("Ошибка. Повторите ввод: ");
    }
}

// getting numbers for comparing

int [] compare =new int[count];

GenerateList(compare);

int [] mainValues=Compare(compare);

string odds=getOdds(mainValues);

int min=mainValues[0];
int max=mainValues[1];

// Printing all results

Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Максимум: {max}");
Console.WriteLine($"Все четные числа между крайними значениями(включая их): {odds}");
