/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num;
Console.Write($"Quad of {num} -> {quad} " );*/


/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет*/

/*Console.WriteLine("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if (quad == num1)
{
    Console.WriteLine($"{num1} is quad of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not quad of {num2}");
}*/


/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if (quad == num1)
{
    Console.WriteLine($"{num1} is quad of {num2}");
}
else 
{
    Console.WriteLine($"{num1} is not quad of {num2}");
}*/



/*Console.WriteLine("Input number N");
int numN = Convert.ToInt32(Console.ReadLine());
int count = numN * (-1);
while (count <= numN)
{
    Console.WriteLine(count);
    count++;
}*/


/*Console.WriteLine("Input number N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (numN % 10);*/


/*Console.WriteLine("Input number N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Math.Abs(numN) % 10);*/

Console.WriteLine("Введите число ");
int numN = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= numN)
{
    if (count % 2 ==0)
       Console.Write($"{count}, ");
    count += 1;
}