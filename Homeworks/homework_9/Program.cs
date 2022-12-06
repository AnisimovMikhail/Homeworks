//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if(n >= 1)
//     {
//         Console.Write(n + " ");     
//         ShowNumbers(n - 1);     
//     }
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(N);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumNumber(int M, int N, int sum)
// {
//     if (M > N)
//     {
//         Console.WriteLine($"Сумма чисел:{sum}");
//         return;
//     }
//     sum = sum + M++;
//     Console.Write(sum + " ");
//     SumNumber(M,N,sum);
// }

// Console.Write("Введите начало промежутка: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец промежутка: ");
// int finish = Convert.ToInt32(Console.ReadLine());

// SumNumber(start,finish,0);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
// вызов Akkerman
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);