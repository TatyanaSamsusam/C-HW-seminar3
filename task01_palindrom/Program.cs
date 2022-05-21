/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.Write("введи число, и я скажу, является ли оно палиндромом: ");
int num = int.Parse(Console.ReadLine());
string saveNum = $"{num}";

if(num > 9999 && num < 100000)
{
    int[] digits = new int[5];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = num % 10;
        num = num / 10;
    }

    if(digits[0] == digits[4] && digits[1] == digits[3])
        {
            Console.WriteLine($"да, {saveNum} - это палиндром");
        }
    else Console.WriteLine($"нет, {saveNum} - это НЕ палиндром");
}

else
{
    Console.WriteLine($"вы ввели не пятизначное число");
}

