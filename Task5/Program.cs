Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

bool Multyp(int num, int a, int b)
{
    return num % a == 0 && num % b == 0;
}
if (Multyp(num1, 7, 23)) 
{
    Console.Write($"{num1} Да");
}
else
{
    Console.Write($"{num1} Нет");
}