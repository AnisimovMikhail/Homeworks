//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int [] CreateArray (int size, int minValue, int maxValue)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//       newArray[i] = new Random().Next(minValue, maxValue + 1)
// ;
//     }
//     return newArray;
// }
// void ShowArray (int[] array)
// {
//     Console.Write("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] ReverseArray (int[] array)
// {   
//     for (int i = 0, j = array.Length -1; i < j; i++, j-- )
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;       
//     }
//     return array;
// }
//  Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(a,min,max);
// ShowArray(myArray);
// ShowArray(ReverseArray(myArray));


//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool CheckTriangle (int a, int b, int c)
// {
//     if (a + b > c && b + c > a && a + c > b)
//     return true;
//     return false;
// }

// int CheckNumber ()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x <= 0) return CheckNumber();
//     else return x;
// }
// Console.WriteLine("Input Length A : ");
// int a = CheckNumber();
// Console.WriteLine("Input Length B : ");
// int b = CheckNumber();
// Console.WriteLine("Input Length C : ");
// int c = CheckNumber();

// Console.WriteLine(CheckTriangle(a,b,c));


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

// void Fibonacci (int n, int a, int b)
// {
//     int [] array = new int[n];
//     array[0] = a;
//     array[1] = b;
//     for (int i = 2; i <= array.Length; i++)
//     {
//         array[i] = array[i-2] + array[i-1];
//         Console.WriteLine(array[i]);
//     }

// }
// Console.WriteLine("Input first Fibonacci: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second Fibonacci: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input fird Fibonacci: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Fibonacci(c,a,b);


//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

string TenInTwo (int number)
{
    string result = string.Empty;
    while(number > 0)
    {
        result = ((number % 2 == 0) ? "0" : "1") + result;
        number = number / 2;
    }
    return result;
}
Console.Write("Input first Fibonacci: ");
int a = Convert.ToInt32(Console.ReadLine());
string Temp = TenInTwo(a);
Console.WriteLine(Temp);