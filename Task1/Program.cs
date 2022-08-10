int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// {
//     Console.Write($"Наибольшая цифра числа --> {firstDigit}");
// }
// else if (firstDigit == secondDigit)
// {
//     Console.Write($"Обе цифры числа равны!");
// }
// else
// {
//     Console.Write($"Наибольшая цифра числа --> {secondDigit}");
// }

// int res = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(res);

int MaxDigit(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(88);
string res = result == -1 ? "Цифры одинкаовы" : result.ToString();
Console.Write($"Наибольшая цифра числа {number}--> {res}");

