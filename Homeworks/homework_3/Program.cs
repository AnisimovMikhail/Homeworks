// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubicNum (int numN)
{
    Console.WriteLine($"Кубические числа от 1 до {numN}");
    for (int i = 1; i < numN + 1; i++)
    {
        Console.Write($" |{i} = {i * i * i}| ");
    }
}
Console.WriteLine("Введите число ");
int result = Convert.ToInt32(Console.ReadLine());
CubicNum (result);
