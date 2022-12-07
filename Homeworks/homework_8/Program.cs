// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
// {                                                                           
//   int[,] newArray = new int[rows, columns];  

//   for (int i = 0; i < rows; i++)
//   {
//      for(int j = 0; j < columns; j++)
//      {
//        newArray[i,j] = new Random().Next(minValue,maxValue + 1);
//      }
//   }
//   return newArray;    
// }

// void ShowArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//       for(int j = 0; j < array.GetLength(1); j++)  
//       {
//         Console.Write(array[i,j] + " ");
//       }
//       Console.WriteLine(); 
//     }
// }

// void OrderNumbers (int [,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         int temp = array[i, k + 1];
//         if (array[i, k] < array[i, k + 1])
//         {
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
//   Console.WriteLine("Получившийся массив: ");
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] oldArray = CreateRandom2DArray(rows, colums, min, max);
// ShowArray(oldArray);
// OrderNumbers(oldArray);
// ShowArray(oldArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateRandom2DArray(int rows, int columns)  
// {      
//     // Инициализация массива
//     int[,] newArray = new int[rows, columns];  
    
//     if( rows > 0 && columns > 0)
//     {
//         // создание массива
//         for (int i = 0; i < rows; i++)
//         {
//             for(int j = 0; j < columns; j++)
//             {
//             newArray[i,j] = new Random().Next(1, 11);
//             }
//         }

//         // Отображение массива
//         for(int i = 0; i < rows ;i++ ) 
//             {
//                 for(int j = 0; j < columns; j++)  
//                 {
//                 Console.Write(newArray[i,j] + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//         Console.WriteLine();    
//         return newArray;
//     }
//     else 
//     {
//         Console.WriteLine("Ошибка ввода данных");
//         return newArray;
//     }

// }

// void FindMinSum (int [,] array)
// {
//   int sizesumarray = array.GetLength(0);
//   int [] sum = new int [sizesumarray];
//   for (int i = 0; i < array.GetLength(0);i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       sum[i] += array[i,j];
//     }
//       Console.WriteLine($"Сумма строки {i+1} равна {sum[i]}");
//   }
//    int Minsum = 0;
//    for (int i = 0; i < sum.GetLength(0); i++)
//    {
//     Minsum = sum[0];
//     if(sum[i] < Minsum) Minsum = sum[i];
//    }
//    Console.WriteLine($"Мнимальная сумма -> {Minsum}");
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] newArray = CreateRandom2DArray(rows, columns);
// FindMinSum(newArray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandom2DArray(int rows, int columns)  
{      
    // Инициализация массива
    int[,] newArray = new int[rows, columns];  
    
    if( rows > 0 && columns > 0)
    {
        // создание массива
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
            newArray[i,j] = new Random().Next(1, 11);
            }
        }

        // Отображение массива
        for(int i = 0; i < rows ;i++ ) 
            {
                for(int j = 0; j < columns; j++)  
                {
                Console.Write(newArray[i,j] + " ");
                }
                Console.WriteLine(); 
            }
        Console.WriteLine();    
        return newArray;
    }
    else 
    {
        Console.WriteLine("Ошибка ввода данных");
        return newArray;
    }

}

int [,] MultiPly (int [,] array1, int[,] array2)
{
  int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    for (int j = 0; j < array1.GetLength(1); j++)
    {
      newArray[i,j] = array1[i,j] * array2[i,j];
    }
  }
  Console.WriteLine("Произведение двух массивов");
  for(int i = 0; i < array1.GetLength(0) ;i++ ) 
            {
                for(int j = 0; j < array1.GetLength(1); j++)  
                {
                Console.Write(newArray[i,j] + " ");
                }
                Console.WriteLine(); 
            }
        Console.WriteLine();
  return newArray;      
}

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] newArray1 = CreateRandom2DArray(rows, columns);
int [,] newArray2 = CreateRandom2DArray(rows, columns);
MultiPly(newArray1,newArray2);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07