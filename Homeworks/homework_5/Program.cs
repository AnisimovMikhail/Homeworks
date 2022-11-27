﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreatArray (int size)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
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
// void FindEvenNumber (int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     Console.Write($"Четных чисел -> {count}");
// }
// Console.Write("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreatArray(size);
// ShowArray(newArray);
// FindEvenNumber(newArray);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] CreatArray (int size)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(1, 100);
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
// void OddPosition(int [] number)
// {
//     int summa = 0;
//     for(int j = 0; j < number.Length; j++)
//     {
//         if (j % 2 != 0) summa = summa + number[j];
//     }
//     Console.Write($" -> {summa}");
// }
// Console.Write("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreatArray(size);
// ShowArray(newArray);
// OddPosition(newArray);





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// int[] CreatArray (int size)
// {
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(-100, 100);
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

// void MaxMinArray (int [] number)
// {
//     int Max = 0;
//     int Min = number[0];
//     int subtraction = 0;

//     for (int j = 0; j < number.Length; j++)
//     {
//         if(Max < number[j]) Max = number[j]; 
//         if(Min > number[j]) Min = number[j];
//     }
//     subtraction = Max - Min;
//     Console.WriteLine($"{subtraction}");
// }
// Console.Write("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreatArray(size);
// ShowArray(newArray);
// MaxMinArray(newArray);



