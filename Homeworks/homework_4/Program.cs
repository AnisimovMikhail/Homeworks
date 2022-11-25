// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int LengthNum (int A)
// {
//     int index = 0;
//     while (A > 0)
//     {
//         A = A / 10;
//         index++;
//     }
//     return index;
// }
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 0; i <= len; i++)
//     {
//         sum = sum + n % 10;
//         n = n / 10;
//     }
//     Console.WriteLine(sum);
// }
// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int len = LengthNum(number);
// SumNumbers(number, len);





// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int NumberInKind (int A, int B)
// {
//     int C = A;
//     for (int i = 1; i < B; i++)
//     {
//         C = C * A;
//     }
//     return C;
// }
// Console.Write("Введите первоу число: ");
// int NumberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int NumberB = Convert.ToInt32(Console.ReadLine());
// int NumAB = NumberInKind(NumberA, NumberB);
// Console.WriteLine($"{NumberA}, {NumberB} -> {NumberInKind(NumberA, NumberB)} ");

