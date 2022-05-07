using System;
Console.Clear();

/* Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.*/
 
 /* Console.Write("Введите координату x: ");
 int x = int.Parse(Console.ReadLine());

 Console.Write("Введите координату y: ");
 int y = int.Parse(Console.ReadLine());

 if (x>0 && y>0)
 {
     Console.WriteLine("Первая четверть");
 }
 if (x<0 && y>0)
 {
     Console.WriteLine("Вторая четверть");
 }
 if (x<0 && y<0)
 {
     Console.WriteLine("Третья четверть");
 }
 if (x>0 && y<0)
 {
     Console.WriteLine("Четвертая четверть");
 }
 else Console.WriteLine("X или Y не должен равняться 0"); */

 /*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

/*Console.WriteLine("Введите первые координаты х, y");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите вторые координаты х, y");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double a = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
Console.WriteLine($"Ответ: {a}"); */


/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.

2 -> 1,4 */

/* int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i}, ");
} */

// StringSplitOptions.RemoveEmptyEntries - удаляет пустые знаечения из массива.

string[] p1 = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);