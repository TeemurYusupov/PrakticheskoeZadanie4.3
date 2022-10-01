// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void FillArray(int[] num)
{
    int razmer = num.Length;
    int i = 0;
    while (i < razmer)
    {
        num[i] = new Random().Next(1, 8);
        i++;
    }
}

void PrintArray(int[]num2)
{
    int razmer2 = num2.Length;
    int j = 0;
    while (j < razmer2)
    {
        Console.Write($" {num2[j]}");
        j++;
    }
}

int[] array = new int [8];

FillArray(array);
PrintArray(array);
