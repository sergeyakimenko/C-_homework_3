/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

Console.Write("Введите x точки A: ");
double ax = int.Parse(Console.ReadLine());

Console.Write("Введите y точки A: ");
double ay = int.Parse(Console.ReadLine());

Console.Write("Введите z точки A: ");
double az = int.Parse(Console.ReadLine());

Console.Write("Введите x точки B: ");
double bx = int.Parse(Console.ReadLine());

Console.Write("Введите y точки B: ");
double by = int.Parse(Console.ReadLine());

Console.Write("Введите z точки B: ");
double bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(az - bz, 2));
Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(result, 2)}");