

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());



    int p = num2 % num1;

    if (num2 % num1 == 0)
        Console.Write("второе кратно первому");
    else 
    {
        Console.Write($"остаток от деления {p}");
    }
    





