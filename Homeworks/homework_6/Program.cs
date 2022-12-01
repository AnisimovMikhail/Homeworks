// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] CreateArray (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
      Console.Write("Введите число ");
      newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void NumberGreaterThanZero (int[] number)
{
    int M = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0) M++;
    }
    Console.Write(M);
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(a);
ShowArray(myArray);
NumberGreaterThanZero(myArray);





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void IntersectionPoint(double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     x = Math.Round(x, 2);
//     y = Math.Round(y, 2);
 
//     Console.WriteLine($"Пересечение: ({x};{y})");
// }
// Console.Write("Задайте координату k1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Задайте координату b1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Задайте координату k2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Задайте координату b2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// IntersectionPoint(x1, y1, x2, y2);