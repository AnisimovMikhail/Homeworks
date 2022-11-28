//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
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

// int [] InvertArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1; // array[i] = array[i] - 1;
//     }
//     return array;
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreateRandomArray(a,min,max);
// // ShowArray(MyArray);
// ShowArray(InvertArray(myArray));
// ShowArray(CreateRandomArray(a,min,max));



//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// int [] InvertArray (int[] array)
// {
//     for (int i = 0; i > array.Length; i++)
//     {
//         array[i] *= -1; 
//     }
//     return array;
// }



//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// + создание метода запроса элементов массива у пользователя
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


// int [] CreateArray (int size)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите элемент {i} ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
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
// bool number1 (int [] array)
// {
//     Console.WriteLine($"Введите число");
//     int number = Convert.ToInt32(Console.ReadLine);
//     for (int i = 0; i < array.length; i++)
//     {
//         if (array[i] == number) return true;
//     }
//     return false;
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// int []MyArray = CreateArray (a);
// ShowArray(MyArray);
// Console.Write(number1(myArray));


// /Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].



int [] CreateArray (int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
      newArray[i] = new Random().Next(1, 1000);
    }
    return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FindNumber (int [] array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++; 
        
    }
    Console.WriteLine(count);
}
Console.Write("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] newArray = CreateArray(size);
ShowArray(newArray);
FindNumber(newArray);