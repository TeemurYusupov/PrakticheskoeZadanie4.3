﻿// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(a,b);
Console.WriteLine(result);