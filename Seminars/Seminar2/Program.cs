//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else 
    {
        return dec;
    }
}

int rand = new Random().Next(10,100);
int result = FindBiggestDigit(rand);
Console.WriteLine($"Your number -> {rand}"); // Вывод нашего числа
Console.WriteLine($"The biggest digit -> {result}"); // Вывод большего из двух
