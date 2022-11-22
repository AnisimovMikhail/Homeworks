/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

/*bool DayOfTheWeek (int num1)
{
    if (num1 == 6 || num1 == 7)
    {
        return true;
    }
    else
    if (num1 < 6 || num1 < 7)
    {
        return false;
    }
    return false;
}

Console.WriteLine("Напишите цифру, обозначающую день недели ");
int random = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{DayOfTheWeek()}");*/



/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int ThreeDigitNum(int num)
{
    int dec = num % 100 / 10;
    return dec;
}
int rand = Convert.ToInt32(Console.ReadLine());
int result = ThreeDigitNum(rand);
Console.WriteLine($"{rand} -> {result}");