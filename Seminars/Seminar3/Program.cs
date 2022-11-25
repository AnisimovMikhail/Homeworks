//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*int findQuart (double x, double y)
{
    if (x > 0 && y > 0) // четверть 1
    return 1;

    if (x < 0 && y > 0) // четверть 2
    return 2;

    if (x < 0 && y < 0) // четверть 3
    return 3;

    if (x > 0 && y > 0) // четверть 4
    return 4;

    return 0; // если ввод 0 или некоректный
}

Console.Write("Введите X: "); //ввод абциссы
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y: "); //ввод ординаты
double y = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine($"The quarter number of our poin {findQuart(x, y)}");*/



//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*void FindCoordinats (int quart)
{
    if (quart < 1 || quart > 4)
    Console.WriteLine("Такой четверти не существует!");
    if (quart == 1)
     Console.WriteLine("Диапазон координат в I четверти (x>0 ; y>0");
      if (quart == 2)
    Console.WriteLine("Диапазон координат в II четверти (x<0 ; y>0");
      if (quart == 3)
    Console.WriteLine("Диапазон координат в III четверти (x<0 ; y<0");
      if (quart == 4)
    Console.WriteLine("Диапазон координат в IV четверти (x>0 ; y<0");
}
Console.WriteLine("Введите номер четверти ");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordinats (quart);*/


//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

/*void DistansPoint(double x, double y, double x1, double y1)
{
    double distx = x1 - x;
    double disty = y1 - y;
    double distc = Math.Sqrt(distx * distx + disty * disty);
    Console.WriteLine($"Расстояние между точками {distc} ");
    
}
Console.WriteLine("Задайте координату X ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату Y ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату X1 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату Y1 ");
double y2 = Convert.ToDouble(Console.ReadLine());
DistansPoint(x1, y1, x2, y2);*/



//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

void NumberN(int A)
{
    Console.WriteLine($"Квадраты чисел от 1 до {A}: ");
    for (int i = 1; i < A + 1; i++)
    {
      Console.Write($"{i} = {i*i} ");
    }
}
Console.WriteLine("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
 NumberN(Number);