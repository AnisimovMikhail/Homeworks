﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubicNum (int numN)
// {
//     Console.WriteLine($"Кубические числа от 1 до {numN}");
//     for (int i = 1; i < numN + 1; i++)
//     {
//         Console.Write($" |{i} = {i * i * i}| ");
//     }
// }
// Console.WriteLine("Введите число ");
// int result = Convert.ToInt32(Console.ReadLine());
// CubicNum (result);


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




void Palindrom(int number)
{
    if(number >= 10000)
    {
    int delenie1 = number / 10000;
    int remainder1 = number % 10;
    if(delenie1 == remainder1)
    {
        number = number / 10;
        int delenie2 = number / 100 % 10;
        int remainder2 = number % 10;
        if(delenie2 == remainder2)
        Console.WriteLine("ДА");
    }
    else 
    Console.WriteLine(" НЕТ");      
    }
}
Console.Write("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);





// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*void DistansPoint(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distX = x2 - x1;
    double distY = y2 - y1;
    double distZ = z2 - z1;
    double XYZ = Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
    Console.WriteLine($"Расстояние между точками {XYZ} ");
    
}
Console.WriteLine("Задайте координату X ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату Y ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату Z ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату X1 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату Y1 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату Z1 ");
double z2 = Convert.ToDouble(Console.ReadLine());
DistansPoint(x1, y1, z1, x2, y2, z2);*/

