Console.Clear();
Console.Write("Сколько чисел сравниваем (2-5): ");
int count =1;

while (count<2||count>5){
    count=int.Parse(Console.ReadLine());
    if (count<2||count>5){
        Console.Write("Ошибка. Повторите ввод: ");
    }
}

int i;
int [] compare =new int[count];

for (i=0;i<count;i++){
    Console.Write($"Введите число №{i+1}:");
    compare[i]=int.Parse(Console.ReadLine());
}

int max;
int min;

if (compare[0]>compare[count-1]){
        max=compare[0];
        min=compare[count-1];
} else {
        min=compare[0];
        max=compare[count-1];
}

string numbers="";

for (i=0;i<count;i++){
    if (compare[i]>max){
        max=compare[i];
    } else if (compare[i]<min){
        min=compare[i];
    }
    if (i<count-1){
        numbers+=compare[i].ToString()+",";
    } else {
        numbers+=compare[i].ToString();
    }
}

Console.WriteLine("Числа: " + numbers);
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Максимум: {max}");
