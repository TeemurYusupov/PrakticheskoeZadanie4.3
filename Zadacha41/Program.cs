﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();

Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа для массива  ");
int[] array = new int[m];

int nut = 0;

for( int i = 0; i < array.Length; i++ )
{
    Console.WriteLine();
    int possition = Convert.ToInt32(Console.ReadLine());
    array[i] = possition;
    Console.Write("принято -> нажмите [enter]");
    
    if (array[i] > 0)
    {
        nut += 1;
    }
    
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"         колличество положительных чисел = [{nut}]");