// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = new int[5];
int num = array.Length;

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(1, 30);
    Console.Write($" {array[i]}");           // заполнение
}

int max = array[0];
int min = array[0];
int rez = 0;

for (int j = 0; j < num; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }                                    //нахождение максимального значения

    if (array[j] < min)
    {                               //нахождение минимального значения
        min = array[j];
    }
}

Console.WriteLine();
Console.WriteLine($"/ max = {max}");
Console.WriteLine($"/ min = {min}");
rez = max - min;
Console.WriteLine($"/ max - min = {rez}");