﻿//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers(int n)
// {
//     if(n >= 1)
//     {
//         ShowNumbers(n - 1);      //вывод нашего метода

//         Console.Write(n + " ");     
//     }
// }
// ShowNumbers(6);


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum (int num)  //456
// {
//     if(num > 0) //456
//     {
//        return FindSum(num / 10) + num % 10; 
//     }
//     else
//     return num;
// }
// int sum = FindSum(456);
// Console.WriteLine(sum);


//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void findInterval(int start, int finish)
// {
//     if (start != finish)
//     {
//         if ( start > finish)
//         {
//             findInterval(start - 1, finish);
//             Console.Write(start + " ");

//         }
//         else
//         {
//             findInterval(start, finish - 1);
//             Console.Write(finish + " ");

//         }
//     }
//     else Console.Write(start + " ");
// }

// Console.WriteLine("Введите начало промежутка ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конец промежутка ");
// int finish = Convert.ToInt32(Console.ReadLine());

// findInterval(start, finish);


//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int PowNumber (int A, int B)
{
    if (B > 1)
    {
        return A * PowNumber (A, B - 1);
    }
    return A;
}

Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumber(A,B));