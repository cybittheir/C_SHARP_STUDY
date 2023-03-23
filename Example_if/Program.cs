
    string greeting="Введите имя пользователя: ";

    Console.Write(greeting);

    string username = Console.ReadLine();

    if (username!="" && username.ToLower()=="маша")
    {
        Console.WriteLine("Ура, это же Маша!!!");

    }
    else if(username!="") 
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    } else {

        Console.Write("Привет, anonymous...");

    }
