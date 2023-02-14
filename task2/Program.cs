// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89456 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {NumOfDigits(num)}");

int NumOfDigits(int number)
{
    int result = 1;
    while (number > 10)
    {
        number = number / 10;
        result++;
    }
    return result;
}
