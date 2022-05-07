using System;
Console.Clear();

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

string[] A = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int x1 = int.Parse(A[0]);
int y1 = int.Parse(A[1]);
int z1 = int.Parse(A[2]);
int x2 = int.Parse(A[3]);
int y2 = int.Parse(A[4]);
int z2 = int.Parse(A[5]);

double square = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

Console.Write($"Ответ: A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {square:f2}");