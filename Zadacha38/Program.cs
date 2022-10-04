// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = new int[5];
int num = array.Length;
int i = 0;
int sum = 0;               //переменные  
int min = 0;
int max = 0;

while (i < num)
{
    array[i] = new Random().Next(1, 30);
    Console.Write($" {array[i]}");           // заполнение
    
    
    if (array[i] > max)
    {
        max = array[i];
    }                            //поиск макс
    
    if (array[i] < max)
    {
        min = array[i];         // поиск мин
    }
    
    i++;
}
// Console.WriteLine($"/  {max}");
// Console.WriteLine($"/  {min}");

sum = min + max;
Console.WriteLine($" / min + max = {sum}");