/* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("введите число, и я выдам таблицу кубов от 1 до вашего числа: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"вот таблица кубов от 1 до {number}:");

for (int i = 1; i <= number; i++)
{
    for(int j = 1; j <= number; j++)
    {
        Console.WriteLine($"{j * j * j}");
    }
    break;
}