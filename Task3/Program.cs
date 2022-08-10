// Напишите программу которая принимает рандомное число и удаляет вторую цифру


int number = new Random().Next(100, 1000);

int RemoveSecons(int num)
{
    int number1 = num / 100;
    int number2 = num % 10;
    int nov = number1 * 10 + number2;
    return nov;
}

int result = RemoveSecons(number);
Console.Write($"{number} ==> {result}");

