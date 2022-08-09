int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.Write($"Наибольшая цифра числа --> {firstDigit}");
}
else if (firstDigit == secondDigit)
{
    Console.Write($"Обе цифры числа равны!");
}
else
{
    Console.Write($"Наибольшая цифра числа --> {secondDigit}");
}
