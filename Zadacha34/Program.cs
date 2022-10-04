// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
int[] array = new int[5];
int num = array.Length;
int i = 0;
int sum = 0;
while (i < num)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"  {array[i]}");
    
    
    if (array[i] % 2 == 0)
    {
        sum += 1;
    }
    
    
    i++;
}
Console.WriteLine($" / чётных чисел  ->   [{sum}]");