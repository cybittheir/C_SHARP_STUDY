Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int number2=number*(-1);

int i;

if (number>number2){
    for(i=number2;i<=number;i++){
        Console.WriteLine(i);
    }

} else {

    for(i=number;i<=number2;i++){
        Console.WriteLine(i);
    }
}

int min;
int max;
if (number>number2){
    min=number2;
    max=number;
} else {
    min=number;
    max=number2;
}

for(i=min;i<=max;i++){
    Console.WriteLine(i);
}
