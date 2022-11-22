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
Console.WriteLine("Напишите цифру, обозначающую день недели ");
int numN = Convert.ToInt32(Console.ReadLine());
bool newNumber = DayOfTheWeek(numN);
Console.WriteLine($"{numN} -> {newNumber} ");*/



/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*int ThreeDigitNum(int num)
{
    int dec = num % 100 / 10;
    return dec;
}
int rand = Convert.ToInt32(Console.ReadLine());
int result = ThreeDigitNum(rand);
Console.WriteLine($"{rand} -> {result}");*/


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void HirdDigit(int number)
{
   int sot = number % 100;
   if (sot == number )
   {
    Console.WriteLine("Третьей цифры нет ");
   }
   else 
   {
   int ab = ((number / 100) % 10);
   Console.WriteLine($"{number} -> {ab}");
   } 
}
 int newNumber = Convert.ToInt32(Console.ReadLine());
 HirdDigit(newNumber);


