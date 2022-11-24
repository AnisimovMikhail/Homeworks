// Задача 23
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


bool Polindrom (int num1, int num2, int num3, int num4, int num5) 
{
    if ( (num1 - num5) * (num1 - num5) == 0 &&  ( num2 - num4) * (num2 - num4) == 0 && (num3 - num3) == 0 )
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());
bool newNumber = Polindrom(Number);
Console.WriteLine($"{Number} -> ");









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

