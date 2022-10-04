// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

int[] array = new int[5];
int num = array.Length;
int i = 0;
int sum = 0;

while (i < num)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($"  {array[i]}");
    
    if (array[i] % 2 > 0)
    {
        sum += array[i];
    }
    
    i++;
}
Console.WriteLine($" / сумма не чётных чисел  = [{sum}]");