// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"{N} -> {MultiplicationOfNums(N)}");

int MultiplicationOfNums(int number)
{
    int result = 1;
    while (number > 1)
    {
        result *= number;
        number--;
    }
    return result;
}
