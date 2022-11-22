//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

/*int FindBiggestDigit (int num)
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
Console.WriteLine($"The biggest digit -> {result}"); // Вывод большего из двух*/

//2 Задача.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int CutNumber (int num)
{
  int ed = num % 10;
  int sot = num / 100;
  int res = sot * 10 + ed;
  return res;  
}

int random = new Random().Next(100,1000);
int newNumber = CutNumber(random);
Console.WriteLine($"New version of {random} is {newNumber}");

//Задача 3.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

/*void main (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine(num1 / num2);
    }
    else
    {
        Console.WriteLine(num1 % num2);
    }
}
main(17,4);*/

//4 Задача.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да

/*bool KratNumber (int num1)
{
    if (num1 % 7 == 0 && num1 % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}
Console.WriteLine($"{KratNumber(46)}");*/

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
    {
        return false;
    }
}
Console.WriteLine($"{DayOfTheWeek(7)} ");*/